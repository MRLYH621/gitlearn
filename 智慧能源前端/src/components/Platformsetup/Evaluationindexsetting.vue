<template>
    <div id='ensemble '>
    <div id="crumbs" style="width: 100%;height: 40px;line-height: 40ppx;padding:5px 20px">
            <ul>
                <li><a href="#">当前页 <Icon type="ios-home-outline"></Icon></a></li>
                <li><a href="#">平台设置</a></li>
                <li><a href="#">评估指标设置</a></li>
            </ul>
        </div>
        <el-form :label-position="labelPosition" label-width="100px" :model="formLabelAlign" class="f1">
                <el-form-item label="系统类型：">
                        <el-select v-model="SysType" placeholder="请选择">
                                <el-option v-for="item in SysTypes" :key="item.ID" :label="item.TypeName" :value="item.ID">
                                </el-option>
                        </el-select>
                        <el-button type="primary" @click="loadSys">确认</el-button>
                </el-form-item>
                <el-form-item label="运行模式：">
                        <el-select v-model="SysMode" placeholder="请选择">
                                <el-option v-for="item in SysModes" :key="item.ID" :label="item.M_Name" :value="item.ID">
                                </el-option>
                        </el-select>
                        <el-button type="primary" @click="loadSys">确认</el-button>
                </el-form-item>
                <el-form-item label="系统名称：">
                        <el-select v-model="SysInfo" placeholder="请选择">
                                <el-option v-for="item in SysInfos" :key="item.Sn" :label="item.Pname" :value="item.Sn">
                                </el-option>
                        </el-select>
                        <el-button type="primary">确认</el-button>
                </el-form-item>
                <el-form-item label="指标名称：">
                        <el-select v-model="Target" placeholder="请选择">
                                <el-option v-for="item in Targets" :key="item.ID" :label="item.T_Name" :value="item.ID">
                                </el-option>
                        </el-select>
                        <el-button type="primary" @click="dialogFormVisible = true">配置公式</el-button>
                        </el-form-item>
                <el-form-item label="权   重：">
                        <el-input v-model="formLabelAlign.type"  placeholder="请输入权重" style="width: 28%"></el-input>
                        <el-button type="primary">确认</el-button>
                </el-form-item>
                <el-form-item label="指标对标：">
                        <el-input v-model="formLabelAlign.type"  placeholder="请输入指标对标" style="width: 28%"></el-input>
                        <el-button type="primary">确认</el-button>
                </el-form-item>
               <el-button type="primary" @click="handleSubmit()" class="submit_SZ">保存设置</el-button>
        </el-form>
        <el-dialog title="数据源绑定" :visible.sync="dialogFormVisible" class="f2">
                <div class="f_top">
                        <div class="f3">XXX指标</div>
                        <div class="f4">
                                <ul>
                                        <li>A</li>
                                        <li>B</li>
                                        <li>C</li>
                                </ul>
                        </div>
                        <div>
                                <el-button type="primary" @click="display">绑定数据源</el-button>
                                <el-button type="primary" @click="display1">手动录入</el-button>
                        </div>
                </div>
                <div>
                        <div id="f4"  v-show="isShow">
                                <el-select v-model="value" placeholder="请选择">
                                        <el-option
                                                v-for="item in options"
                                                :key="item.value"
                                                :label="item.label"
                                                :value="item.value">
                                        </el-option>
                                </el-select>
                              <el-button type="primary">确 定</el-button>
                        </div>
                        <div id="f5"  v-show="isShow1">       
                                <el-input v-model="input" placeholder="请输入内容" style="width: 44%"></el-input>
                                <el-button type="primary">确 定</el-button>
                        </div>
                </div>
                <div slot="footer" class="dialog-footer">
                        <el-button type="primary">保存设置</el-button>
                </div>
        </el-dialog>
    </div>
</template>
<script>
    export default {
       data () {
         return {
                labelPosition: 'right',
                formLabelAlign: {
                        name: '',
                        region: '',
                        type: ''
                },
                dialogFormVisible: false,
                options:[
                        {value:"1",label:"数据源1"},
                        {value:"2",label:"数据源2"},
                ],
                value:'',
                input:"",
                isShow: false,
                isShow1: false,
                SysType:'',
                SysTypes:[],
                SysMode:'',
                SysModes:[],
                SysInfo:'',
                SysInfos:[],
                Target:'',
                Targets:[],
         }
        },
        mounted(){
                this.LoadSysTyoe();
                this.LoadSysMode();
                this.LoadTarget();
        },
        methods: {
                handleSubmit () {
                        console.log("111")
                },
                display(){
                        this.isShow1 = false;
                        this.isShow = !this.isShow; 
                },
                display1(){
                        this.isShow = false;
                        this.isShow1 = !this.isShow1; 
                },
                loadSys(){
                        var url = this.$api+'Plat/GetStationInfos?SysType='+this.SysType+'&SysMode='+this.SysMode;
                        var oldThis = this;
                        this.$axios.get(url).then(function (response) {
                                oldThis.SysInfos=[];
                                oldThis.SysInfos=response.data;
                        }).catch(function (error) {
                        　　    alert(error);
                        });
                },
                LoadSysTyoe(){
                        var url = this.$api+'Plat/GetStationType';
                        var oldThis = this;
                        this.$axios.get(url).then(function (response) {
                                oldThis.SysTypes=[];
                                oldThis.SysTypes=response.data;
                        }).catch(function (error) {
                        　　    alert(error);
                        });
                },
                LoadSysMode(){
                        var url = this.$api+'Plat/GetStationMode';
                        var oldThis = this;
                        this.$axios.get(url).then(function (response) {
                                oldThis.SysModes=[];
                                oldThis.SysModes=response.data;
                        }).catch(function (error) {
                        　　    alert(error);
                        });
                },
                LoadTarget(){
                        var url = this.$api+'Plat/GetTarget';
                        var oldThis = this;
                        this.$axios.get(url).then(function (response) {
                                oldThis.Targets=[];
                                oldThis.Targets=response.data;
                        }).catch(function (error) {
                        　　    alert(error);
                        });
                },
        }
    }
</script>
<style scoped>
         /* .f1 >>> .ivu-form-item-label{color: white;font-size: 16px;font-weight: 700}

         .ivu-input-wrapper,.ivu-select{width: 35% !important} */
         .f1{width:70%;margin:0 auto}
         .f1 >>>  .el-form-item__label{color: white;font-size: 16px;font-weight: 700}
         .f_top{display: flex;justify-content: flex-start;}
         .f3{width: 30px;font-size: 18px;}
         .f4{width: 100px;height: 100px;overflow-y: scroll;border: 2px solid #ccc;}
        .submit_SZ{width:200px;margin:10px 100px;}
</style>