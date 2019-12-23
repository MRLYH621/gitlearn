<template>
        <div id='information '>
         <div id="crumbs" style="width: 100%;height: 40px;line-height: 40ppx;padding:5px 20px">
            <ul>
                <li><a href="#">当前页 <Icon type="ios-home-outline"></Icon></a></li>
                <li><a href="#">能源监测</a></li>
                <li><a href="#">集中监测</a></li>
                <li><a href="#">系统检测</a></li>
                <li><a href="#">设备信息</a></li>
            </ul>
             <button @click="back()"  class="goback">返回</button>
        </div>
        <div class="top_H">
                    <h3>示例系统（系统名称）</h3>
            </div>
                <div class="demo-split">
                        <Split>
                            <div slot="left" class="demo-split-pane no-padding">
                                    <div style="text-align: center;font-size: 18px;line-height: 30px;">
                                        <h3>设备基本信息</h3>
                                    </div>
                                    <div class='productivityanalysis-screen-box-table'>
                                            <!-- <table border="1" border-color="red">
                                                    <tbody>
                                                        <tr  v-for="item in totalData2">
                                                            <td>{{item.RoleName}}</td>
                                                            <td>{{item.RoleDescription}}</td>
                                                            <td>{{item.RoledC}}</td>
                                                            <td>{{item.RoledS}}</td>
                                                        </tr>
                                                        <tr  v-for="(item,index) in totalData3">
                                                                <td>
                                                                       编辑
                                                                </td>
                                                            <td>
                                                                    <router-link :to="{path:'editing',query:{UserID: index}}">
                                                                            <Icon type="ios-create-outline" title="编辑角色" style='cursor: pointer'/>
                                                                        </router-link>
                                                            </td>
                                                            <td>
                                                                    <router-link :to="{path:'editing',query:{UserID: index}}">
                                                                            <Icon type="ios-create-outline" title="编辑角色" style='cursor: pointer'/>
                                                                        </router-link>
                                                            </td>
                                                            <td>
                                                                    <router-link :to="{path:'editing',query:{UserID: index}}">
                                                                            <Icon type="ios-create-outline" title="编辑角色" style='cursor: pointer'/>
                                                                        </router-link>
                                                            </td>
                                                            </tr>
                                                    </tbody>
                                                </table> -->
                                                <!-- <el-table :data="totalData2" max-height="460"  @cell-click="cellClick"
                :cell-class-name='getCellIndex' :cell-style="setCellStyle">
                <el-table-column fixed prop="RoleName" width="100"></el-table-column>
                <el-table-column
                prop="RoleDescription"
               >
              </el-table-column>
            </el-table> -->
                                    </div>
                                    <Table border  height="400" width="540" :columns="columns7" :data="data6" class="table_1">
                                            <template slot-scope="{ row, index }" slot="edit">
                                                    <router-link :to="{path:'editing',query:{UserID:index}}">
                                                            <Icon type="ios-create-outline" title="编辑角色" style='cursor: pointer' color="green"/>
                                                        </router-link>
                                                </template>
                                    </Table>
                            </div>
                            <div slot="right" class="demo-split-pane">
                                <div class="LS" >
                                    <span>历史数据查询</span>
                                </div>
                                    <div style="line-height:60px;">
                                            <el-date-picker v-model="value6" type="daterange" range-separator="至"                  start-placeholder="开始日期" end-placeholder="结束日期">
                                            </el-date-picker>
                                            <Button type="primary"  size="large">查询</Button>
                                    </div>
                                <div style="line-height:60px;">
                                    <input type="text" placeholder="请输入参数名称" class="history_data"> 
                                    <Button type="primary"  size="large">精准查询</Button>
                                    <Button type="primary" size="large" @click="exportData()"><Icon type="ios-download-outline"></Icon> 历史数据</Button>
                                </div>
                                <div>
                                        <Table height="400" :columns="columns1" :data="data2" ref="table"></Table>
                                </div>
                                
                            </div>
                        </Split>
                    </div>
        </div>  
</template>
<script>
    export default{
        data(){
            return{
                value6: '',
                currentPage3: 5,
                totalData2:[
                            {RoleID:0,RoleName:"设备名称",RoleDescription:"系统管理",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:1,RoleName:"运行状态",RoleDescription:"系统管理1",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:2,RoleName:"通信状态",RoleDescription:"系统管理2",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:4,RoleName:"故障信息",RoleDescription:"系统管理4",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:5,RoleName:"设备类型",RoleDescription:"系统管理",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:6,RoleName:"设备型号",RoleDescription:"系统管理1",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:7,RoleName:"安装位置",RoleDescription:"系统管理2",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:8,RoleName:"厂家",RoleDescription:"系统管理4",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:8,RoleName:"厂家联系方式",RoleDescription:"系统管理4",RoledC:"XXX",RoledS:"XXX"},
                            {RoleID:9,RoleName:"编辑",RoleDescription:"<i class='el-icon-edit-outline'></i>",RoledC:"XXX",RoledS:"XXX"},
                    ],
                    totalData3:[
                        {to:"editing",index:1}
                    ],
                    columns7: [
                    {
                        title: '设备名称',
                        key: 'name'
                    },
                    {
                        title: '运行状态',
                        key: 'name'
                    },
                    {
                        title: '通信状态',
                        key: 'name'
                    },
                    {
                        title: '故障信息',
                        key: 'name'
                    },
                    {
                        title: '设备类型',
                        key: 'name'
                    },
                    {
                        title: '设备型号',
                        key: 'name'
                    },
                    {
                        title: '安装位置',
                        key: 'name'
                    },
                    {
                        title: '厂家',
                        key: 'name'
                    },
                    {
                        title: '厂家联系方式',
                        key: 'name'
                    },
                    {
                        title: '编辑',
                        slot: 'edit',
                        align: 'center',
                    }
                ],
                data6: [
                    {
                        name: '设备名称',
                        aount2: 'XXXX',
                    },
                    {
                        name: '设备',
                        aount2: 'XXXX',
                    },
                    {
                        name: '设备名称',
                        aount2: 'XXXX',
                    },
                  
                ],
                columns1: [
                    {
                        title: '设备名称',
                        children: [
                            {
                                title: '参数名称',
                                key: 'name',
                                align: 'center',
                            },]
                    },
                    {
                        title: '设备名称',
                        children: [
                            {
                                title: '参数名称',
                                key: 'name',
                                align: 'center',
                            },]
                    },
                    {
                        title: '设备名称',
                        children: [
                            {
                                title: '参数名称',
                                key: 'name',
                                align: 'center',
                            },]
                    },
                    {
                        title: '时间',
                        key: 'date'
                    }
                ],
                data2: [
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-03'
                    },
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-01'
                    },
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-02'
                    },
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-04'
                    },
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-03'
                    },
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-01'
                    },
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-02'
                    },
                    {
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        name: '参数值',
                        date: '2016-10-04'
                    }
                ],
            }
        },
        mounted(){
        },
        methods:{
            back(){
                this.$router.go(-1);//返回上一层
            },
            // show (index) {
            //     this.$Modal.info({
            //         content: `name：${this.data6[index].name}<br>aount1：${this.data6[index].aount1}<br>aount2：${this.data6[index].aount2}`
            //     })
            // },
            // 导出数据
            exportData (){
                this.$refs.table.exportCsv({
                    filename: '历史数据'
                })
            },
            cellClick: function (row, column, cell, event) {
                console.log(column.index);
                // var index = $(cell).index();
                this.forecastTime = parseFloat(column.label);
                this.size = parseFloat(row.size);
                // console.log(index, this.forecastTime);
                this.rowIndex = row.index;
                this.columnIndex = column.index;
                this.$router.push({path:'/editing',query:{index: this.columnIndex}})
                },
            getCellIndex: function ({ row, column, rowIndex, columnIndex }) {
                row.index = rowIndex;
                column.index = columnIndex;
            },
            setCellStyle: function ({ row, column, rowIndex, columnIndex }) {
                if (rowIndex === this.rowIndex && columnIndex === this.columnIndex) {
                    return { "background-color": "#009221" }
                }
            }
        },
        watch:{}
    }
</script>
<style scoped>
    .container_box{
        display: flex;
        color:#fff;
    }
    .container_box>div{
        flex: 1;
        
    }
    .demo-split{
        height: 600px;
        /* border: 1px solid #dcdee2; */
        color: #fff;margin-top: 30px;
    }
    .demo-split-pane{
        padding: 10px;
    }
    .demo-split-pane.no-padding{
        height: 600px;
        padding: 0;
    }
    div.ivu-table-header{
        display: none !important
    }
    .LS{
        width: 30px;font-size: 18px;float: left;display:flex;align-items:center;height:425px;
    }
    .top_H>h3{
        text-align: center;  font-size: 18px; color: #3366CC;width: 40%;margin: 0 auto;height: 30px;line-height: 30px;background: #fff;border-radius: 5px;
    }
    .history_data{height:40px;line-height:40px;border-radius:5px;}
    .productivityanalysis-screen-box-table{
        width:95%;
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
    
</style>
<style>
    .productivityanalysis-screen-box-table .el-table__header{display: none !important}
</style>