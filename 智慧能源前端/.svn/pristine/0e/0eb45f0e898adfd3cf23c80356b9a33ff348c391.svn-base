<template>
        <div id='ensemble'>
                <div id="crumbs" style="width: 100%;height: 40px;line-height: 40ppx;padding:5px 20px">
                        <ul>
                                <li><a href="#">当前页 <Icon type="ios-home-outline"></Icon></a></li>
                                <li><a href="#">平台设置</a></li>
                                <li><a href="#">评估模型管理</a></li>
                                <li><a href="#">模型参数设置</a></li>
                                <li><a href="#">电价时间配置</a></li>
                        </ul>
                        <span @click="back" class="goback">返回</span>
                </div>
                <div  class="ensemble">
                        <div class="E_left">
                                <div>
                                        <Button type="primary" @click="addlist">新增</Button>
                                </div>
                                <div class='productivityanalysis-screen-box-table'>
                                        <table border="1" border-color="red">
                                                <thead>
                                                        <tr>
                                                                <th>时间名称</th>
                                                                <th>开始时间</th>
                                                                <th>结束时间</th>
                                                                <th>编辑</th>
                                                        </tr>
                                                </thead>
                                                <tbody v-for="(item,index) in totalData2">
                                                        <tr>
                                                                <td>{{item.P_Name}}</td>
                                                                <td>{{item.P_StartTime}}</td>
                                                                <td>{{item.P_EndTime}}</td>
                                                                <td>
                                                                        <Icon type="ios-create-outline" title="编辑参数" style='cursor: pointer' @click="append(item,index)"/>
                                                                        <Icon type="ios-trash-outline"style="padding:5px" title='删除参数' @click="dele(item.ID)"/>
                                                                </td>
                                                        </tr>
                                                </tbody>
                                        </table>
                                        <el-dialog title="时间信息编辑" :visible.sync="dialogVisible" width="30%" :before-close="handleClose">
                                                <div>
                                                <el-form :label-position="labelPosition" label-width="100px" :model="model">
                                                        <el-form-item label="时间名称：">
                                                                <el-input v-model="model.P_NAME" placeholder="请输入参数名称"></el-input>
                                                        </el-form-item>
                                                        <el-form-item label="开始时间：">
                                                                <el-time-select v-model="model.P_STARTTIME" :picker-options="{ start: '00:15', step: '00:15', end: '23:45' }" placeholder="选择开始时间">
                                                                </el-time-select>
                                                        </el-form-item>
                                                        <el-form-item label="结束时间：">
                                                                <el-time-select v-model="model.P_ENDTIME" :picker-options="{ start: '00:15', step: '00:15', end: '23:45' }" placeholder="选择结束时间">
                                                                </el-time-select>
                                                        </el-form-item>
                                                </el-form>      
                                                </div>
                                                <span slot="footer" class="dialog-footer">
                                                        <el-button @click="dialogVisible = false">取 消</el-button>
                                                        <el-button type="primary" @click="submitone">确 定</el-button>
                                                </span>
                                        </el-dialog>
                                        <div class='fenyeBox'>
                                        <!-- <Page :total="dataCount" :page-size="PageSize" show-elevator @on-change='handlePageSize' :current='yeMaRole' /> -->
                                        </div>
                                </div>
                        </div>
                </div>    
        </div>
</template>
<script>
export default {
        data() {
                return {
                        totalData2:[],
                        Name:"",
                        model:{
                                ID:0,
                                P_NAME:"",
                                P_STARTTIME:"",
                                P_ENDTIME:"",
                                saveOrUpd:false,
                        },
                        dialogVisible:false,
                        labelPosition: 'right',
                };
        },
        mounted(){
                        this.getData();
                },
        methods: {
                back(){
                        this.$router.go(-1);//返回上一层
                },
                handleInput2(e) {  //验证小数
                        // 通过正则过滤小数点后两位
                        e.target.value = (e.target.value.match(/^\d*(\.?\d{0,1})/g)[0]) || null
                },
                addlist(){
                        this.dialogVisible = !this.dialogVisible;
                        this.model.ID = 0;
                        this.model.P_NAME = '';
                        this.model.P_STARTTIME = '';
                        this.model.P_ENDTIME = 0;
                        this.model.saveOrUpd = false;
                },
                append(item,index){
                        this.dialogVisible = !this.dialogVisible;
                        this.model.ID = item.ID;
                        this.model.P_NAME = item.P_Name;
                        this.model.P_STARTTIME = item.P_StartTime;
                        this.model.P_ENDTIME = item.P_EndTime;
                        this.model.saveOrUpd = true;
                },
                dele(ID){
                        var oldthis = this;
                        var params = new URLSearchParams();
                        var url = this.$api+'Plat/DeleteTOfPrice';
                        params.append('',ID);
                        this.$axios.post(url, params).then(function (response) {
                                if(response.data == -1){
                                        alert("删除失败！");
                                }else{
                                        alert("删除成功！");    
                                        oldthis.getData();      
                                }
                        }).catch(function (error) {
                                oldthis.$toast(error);
                        });
                },
                handleClose(done) {
                        this.$confirm('确认关闭？').then(_ => {
                                done();
                        })
                        .catch(_ => {});
                }, 
                submitone(){
                        var params = new URLSearchParams();   
                        var url = "";
                        if(this.model.saveOrUpd){
                                url = this.$api+'Plat/UpdateTOfPrice';   
                                params.append('ID',this.model.ID);    
                        }else{
                                url = this.$api+'Plat/AddTOfPrice';    
                        }                 
                        var oldThis = this;
                        if(this.model.Name ==''){
                                alert("请输入参数名称！");
                                return;
                        }
                        if(this.model.Code ==''){
                                alert("请输入参数代码！");
                                return;
                        }                        
                        if(this.model.Value ==''){
                                alert("请输入参数值！");
                                return;
                        }                        
                        if(this.model.Unit ==''){
                                alert("请输入单位！");
                                return;
                        }
                        params.append('P_NAME',this.model.P_NAME);     
                        params.append('P_STARTTIME',this.model.P_STARTTIME);
                        params.append('P_ENDTIME',this.model.P_ENDTIME);
                        this.$axios.post(url, params).then(function (response) {
                                if(response.data == -1){
                                        alert('保存失败！');
                                }else if(response.data == -2){
                                        alert('保存失败！');
                                }
                                else{                                        
                                        oldThis.dialogVisible = !oldThis.dialogVisible;
                                        oldThis.getData();          
                                }
                        }).catch(function (error) {
                                　　   alert(error);
                        });
                },
                getData(){
                        var url = this.$api+'Plat/GetTOfPrice';
                        var oldThis = this;
                        this.$axios.get(url).then(function (response) {
                                oldThis.totalData2=[];
                                oldThis.totalData2=response.data;
                                console.log(oldThis.totalData2);

                        }).catch(function (error) {
                                alert(error);
                        });
                }
        }
  };
</script>
<style scoped>
        .ensemble{display: flex;justify-content: flex-start;}
        .E_left{width: 70%}
        .productivityanalysis-screen-box-table{
        width:100%;
        margin-top:10px
        }
    .productivityanalysis-screen-box-table table{
        width:100%;
        color:#00e265
    }
    .productivityanalysis-screen-box-table table td,.productivityanalysis-screen-box-table table th{
        height: 30px;
        line-height: 30px;
        text-align: center
    }
    .productivityanalysis-screen-box-table table thead{
        font-size:700
    }
     .productivityanalysis-screen-box-table table tbody{
        font-size:700;
        color:white
    }
    .fenyeBox{
        width: 100%;
        height: 60px;
        color: #fff;
        display: flex;
        align-items: center;
        justify-content: center
    }
    .float_right{display: flex}
    .float_right a{display: block;width: 100px;height: 40px;line-height: 40px;color: #fff;background: #2d8cf0;border-radius: 5px;flex: 1;margin: 5px;text-align: center;font-size: 16px;font-weight: 700}
</style>