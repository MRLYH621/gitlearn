<template>
        <div id='ensemble '>
        <div id="crumbs" style="width: 100%;height: 40px;line-height: 40ppx;padding:5px 20px">
            <ul>
                <li><a href="#">当前页 <Icon type="ios-home-outline"></Icon></a></li>
                <li><a href="#">系统优化</a></li>
                <li><a href="#">优化运行</a></li>
                 <li><a href="#">敏感性分析</a></li>
            </ul>
        </div>
            <div class="ensemble">
                <div class="flex_left">
                        <div class="flex_left_t">
                                <label for="">评价指标选择：</label>
                                <el-select v-model="value4" clearable placeholder="请选择">
                                        <el-option v-for="item in options" :key="item.value" :label="item.label":value="item.value"></el-option>
                                </el-select>
                                <Button type="primary">确认</Button>
                        </div>
                        <div class="flex_left_t">
                                <label for="">对比参数录入：</label>
                                <el-select v-model="value4" clearable placeholder="请选择">
                                        <el-option v-for="item in options" :key="item.value" :label="item.label":value="item.value"></el-option>
                                </el-select>
                                <input type="text"  v-model="value5" class="ipt_value">
                                <Button type="primary">确认</Button>
                        </div>
                        <div>
                                <el-table :data="tableData4" style="width: 90%"  max-height="250">
                                <el-table-column  prop="name"  label="参数名"   width="120"></el-table-column>
                                <el-table-column prop="original" label="参数原值" width="120"></el-table-column>
                                <el-table-column  prop="contrast" label="对比值"  width="120"></el-table-column>
                                <el-table-column   label="操作"  width="120">
                                        <template slot-scope="scope">
                                        <el-button @click.native.prevent="deleteRow(scope.$index, tableData4)" type="text" size="small"> 移除</el-button>
                                        </template>
                                </el-table-column>
                                </el-table>
                                <el-button type="primary" style="margin: 30px auto 0px 30%;width: 150px;">生成对比图</el-button>
                        </div>
                                        
                </div>
                        <div class="flex_right">
                                <div id='container_column' style="width:400px;height:400px;margin:0 auto"></div>
                                <router-link to="/Sensitivityanalysisreport">生成分析报告</router-link>
                        </div>        
            </div>
         
        </div>
</template>
<script>
        export default {
        data() {
                return {
                        value5:"",
                        options: [{
                                value: '1',
                                label: '评价指标1'
                                }, {
                                value: '2',
                                label: '评价指标2'
                                }, {
                                value: '3',
                                label: '评价指标3'
                                }, {
                                value: '4',
                                label: '评价指标4'
                                }, {
                                value: '5',
                                label: '评价指标5'
                        }],
                        value4: '',
                        tableData4: [{
                                original: '111111111111',
                                name: '参数1',
                                contrast: '1111',
                                }, {
                                original: '12222',
                                name: '参数2',
                                contrast: '2222222',
                                }, {
                                original: '333333',
                                name: '参数3',
                                contrast: '33333333',
                                }, {
                                original: '4444444',
                                name: '参数4',
                                contrast: '4444444',
                                }, {
                                original: '55555555',
                                name: '参数5',
                                contrast: '5555555555',
                               
                                }, {
                                original: '666666',
                                name: '参数6',
                                contrast: '222222222222222222222',
                               
                                }, ]
                }
        },
        mounted(){
                this.get_container_column();
        },
        methods: {
                deleteRow(index, rows) {
                        rows.splice(index, 1);
                },
                get_container_column(){
                        let myChart = this.$echarts.init(document.getElementById('container_column'));
                        myChart.setOption({
                                color: ['#003366', '#006699', '#4cabce', '#e5323e'],
                                tooltip: {
                                        trigger: 'axis',
                                        axisPointer: {
                                        type: 'shadow'
                                        }
                                },
                                legend: {
                                        data: ['Forest', 'Steppe', 'Desert', 'Wetland']
                                },
                                calculable: true,
                                xAxis: [
                                        {
                                        type: 'category',
                                        axisTick: {show: false},
                                        data: ['2012', '2013', '2014', '2015', '2016'],
                                        axisLabel: {
                                                textStyle: {
                                                        color: '#fff'
                                                }
                                        },
                                        }
                                ],
                                yAxis: [
                                        {
                                        type: 'value',
                                        axisLabel: {
                                                textStyle: {
                                                        color: '#fff'
                                                }
                                        }
                                        }
                                ],
                                series: [
                                        {
                                        name: 'Forest',
                                        type: 'bar',
                                        barGap: 0,
                                        data: [320, 332, 301, 334, 390]
                                        },
                                        {
                                        name: 'Steppe',
                                        type: 'bar',
                                        data: [220, 182, 191, 234, 290]
                                        },
                                        {
                                        name: 'Desert',
                                        type: 'bar',
                                        data: [150, 232, 201, 154, 190]
                                        },
                                        {
                                        name: 'Wetland',
                                        type: 'bar',
                                        data: [98, 77, 101, 99, 40]
                                        }
                                ]
                        })
                },
        },
  }
</script>
<style scoped>
        .ensemble{
                display:flex;
                margin-top: 50px;
        }
        .ensemble>div{
                flex: 1
        }
        .flex_left .flex_left_t{
                height: 60px;
        }
        .flex_left .flex_left_t button,.flex_right button{height:40px;}
        .ipt_value{height:40px;line-height:40px;border-radius:5px;}
        .flex_left>div>label{
                color: #fff;
                font-size: 18px;font-weight: 700;line-height: 40px;
        }
        .flex_right>a{
                width: 200px;height: 40px;line-height: 40px;color: #fff;background: #3366CC;border-radius: 5px;display: block;text-align: center;font-size: 16px;margin: 0 auto
        }
</style>