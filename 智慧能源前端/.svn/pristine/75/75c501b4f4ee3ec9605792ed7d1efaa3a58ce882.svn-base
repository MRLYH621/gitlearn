<template>
        <div id='ensemble '>
            <div id="crumbs" style="width: 100%;height: 40px;line-height: 40ppx;padding:5px 20px">
            <ul>
                <li><a href="#">当前页 <Icon type="ios-home-outline"></Icon></a></li>
                <li><a href="#">系统优化</a></li>
                <li><a href="#">仿真数据</a></li>
                 <li><a href="#">负荷</a></li>
            </ul>
             <span @click="back" class="goback">返回</span>
        </div>
            <div class="ensemble">
                <div class="flex_left">
                      <div class="flex_left_t">
                           <label for="">能源类型：</label>
                           <el-select v-model="value4" clearable placeholder="请选择">
                                <el-option v-for="item in options" :key="item.value" :label="item.label" :value="item.value"></el-option>
                          </el-select>
                      </div>
                        <div class="flex_left_t">
                                <label for="">典型日设置：</label>
                                <el-date-picker v-model="value6" type="date" start-placeholder="日期">
                                </el-date-picker>
                        </div>
                        <div class="flex_left_C">
                                <div>
                                        <ul>
                                                <li>
                                                        <label for="">1h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m1">
                                                </li>
                                                <li>
                                                        <label for="">2h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m2">
                                                </li>
                                                <li>
                                                        <label for="">3h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m3">            
                                                </li>
                                                <li>
                                                        <label for="">4h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m4">
                                                </li>
                                                <li>
                                                        <label for="">5h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m5">                        
                                                </li>
                                                <li>
                                                        <label for="">6h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m6">
                                                </li>
                                                <li>
                                                        <label for="">7h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m7">
                                                </li>
                                                <li>
                                                        <label for="">8h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m8">
                                                </li>
                                        </ul>
                                </div>
                                <div>
                                        <ul>
                                                <li>
                                                        <label for="">9h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m9">
                                                </li>
                                                <li>
                                                        <label for="">10h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m10">
                                                </li>
                                                <li>
                                                        <label for="">11h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m11">            
                                                </li>
                                                <li>
                                                        <label for="">12h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m12">
                                                </li>
                                                <li>
                                                        <label for="">13h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m13">                        
                                                </li>
                                                <li>
                                                        <label for="">14h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m14">
                                                </li>
                                                <li>
                                                        <label for="">15h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m15">
                                                </li>
                                                <li>
                                                        <label for="">16h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m16">
                                                </li>
                                        </ul>
                                </div>
                                <div>
                                        <ul>
                                                <li>
                                                        <label for="">17h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW"  v-model="m17">
                                                </li>
                                                <li>
                                                        <label for="">18h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m18">
                                                </li>
                                                <li>
                                                        <label for="">19h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m19">            
                                                </li>
                                                <li>
                                                        <label for="">20h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m20">
                                                </li>
                                                <li>
                                                        <label for="">21h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m21">                        
                                                </li>
                                                <li>
                                                        <label for="">22h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m22">
                                                </li>
                                                <li>
                                                        <label for="">23h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m23">
                                                </li>
                                                <li>
                                                        <label for="">24h：</label>
                                                        <input type="number" @keydown="handleInput2" placeholder="请输入发电功率/kW" v-model="m24">
                                                </li>
                                        </ul>
                                </div>        
                        </div>
                        <Button type="primary" @click="save">保存</Button>                
                </div>
                <div class="flex_right">
                        <div class="flex_right_S">
                                <el-select  v-model="value5"  clearable placeholder="请选择">
                                        <el-option v-for="item in options2" :key="item.value" :label="item.label" :value="item.value"></el-option>
                                </el-select>
                                <Button type="primary" @click="loadcontainer">确认</Button>
                        </div>
                        <div id='container_column' style="width:400px;height:200px"></div>
                        <div id='container_line' style="width:400px;height:200px"></div>
                </div>        
  </div>
 </div>
</template>
<script>
 export default {
        data() {
                return {
                        value4:"",
                        value5:"",                        
                        value6: '',
                        options2: [],
                        options: [{
                                value: '1',
                                label: '冷'
                                }, {
                                value: '2',
                                label: '热'
                                }, {
                                value: '3',
                                label: '电'
                        },],
                        m1:0,
                        m2:0,
                        m3:0,
                        m4:0,
                        m5:0,
                        m6:0,
                        m7:0,
                        m8:0,
                        m9:0,
                        m10:0,
                        m11:0,
                        m12:0,
                        m13:0,
                        m14:0,
                        m15:0,
                        m16:0,
                        m17:0,
                        m18:0,
                        m19:0,
                        m20:0,
                        m21:0,
                        m22:0,
                        m23:0,
                        m24:0,  
                          
                }
        },
        mounted(){
                this.getData();
                this.get_container_column();
                this.get_container_line();
        },
        methods: {
                save:function(){   //保存配置
                        var params = new URLSearchParams();
                        var url = this.$api+'Oper/AddLoad';
                        var oldThis = this;
                        if(this.value4 ==''){
                                alert("请选择能源类型！");
                                return;
                        }
                        params.append('Load_Type',this.value4);
                        
                        var d = new Date(this.value6); 
                        if(this.value6 ==''){
                                alert("请设置典型日！");
                                return;
                        }
                        d=d.getFullYear() + '-' + (d.getMonth() + 1) + '-' + d.getDate();

                        params.append('Load_Date',d);     
                        params.append('Load_Parm_001',this.m1);
                        params.append('Load_Parm_002',this.m2);
                        params.append('Load_Parm_003',this.m3);
                        params.append('Load_Parm_004',this.m4);
                        params.append('Load_Parm_005',this.m5);
                        params.append('Load_Parm_006',this.m6);
                        params.append('Load_Parm_007',this.m7);
                        params.append('Load_Parm_008',this.m8);
                        params.append('Load_Parm_009',this.m9);
                        params.append('Load_Parm_010',this.m10);
                        params.append('Load_Parm_011',this.m11);
                        params.append('Load_Parm_012',this.m12);
                        params.append('Load_Parm_013',this.m13);
                        params.append('Load_Parm_014',this.m14);
                        params.append('Load_Parm_015',this.m15);
                        params.append('Load_Parm_016',this.m16);
                        params.append('Load_Parm_017',this.m17);
                        params.append('Load_Parm_018',this.m18);
                        params.append('Load_Parm_019',this.m19);
                        params.append('Load_Parm_020',this.m20);
                        params.append('Load_Parm_021',this.m21);
                        params.append('Load_Parm_022',this.m22);
                        params.append('Load_Parm_023',this.m23);
                        params.append('Load_Parm_024',this.m24);

                        this.$axios.post(url, params).then(function (response) {
                                if(response.data == -1){
                                        alert('设置失败！');
                                }else if(response.data == -2){
                                        alert('设置失败！');
                                }
                                else{
                                        alert('设置成功！');  
                                         oldThis.getData();             
                                }
                        }).catch(function (error) {
                        　　    alert(error);
                        });
                },
                handleInput2(e) {  //验证小数
                        // 通过正则过滤小数点后两位
                        e.target.value = (e.target.value.match(/^\d*(\.?\d{0,1})/g)[0]) || null
                },
                back(){
                        this.$router.go(-1);//返回上一层
                },
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
                                // legend: {
                                //         data: ['Forest', 'Steppe', 'Desert', 'Wetland']
                                // },
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
                get_container_line(){
                        let myChart1 = this.$echarts.init(document.getElementById('container_line'));
                        myChart1.setOption({
                                // title: {
                                //         text: '折线图堆叠'
                                // },
                                tooltip: {
                                        trigger: 'axis'
                                },
                                // legend: {
                                //         data:['邮件营销','联盟广告','视频广告','直接访问','搜索引擎']
                                // },
                                grid: {
                                        left: '3%',
                                        right: '14%',
                                        bottom: '3%',
                                        containLabel: true
                                },
                                toolbox: {
                                        feature: {
                                        saveAsImage: {}
                                        }
                                },
                                xAxis: {
                                        name:"时间/h",
                                        type: 'category',
                                        boundaryGap: false,
                                        data: ['周一','周二','周三','周四','周五','周六','周日'],
                                        axisLabel: {
                                                textStyle: {
                                                        color: '#fff'
                                                }
                                        },
                                },
                                yAxis: {
                                        name:"发电功率/kW",
                                        type: 'value',
                                        axisLabel: {
                                                textStyle: {
                                                        color: '#fff'
                                                }
                                        },
                                },
                                series: [
                                        {
                                        name:'邮件营销',
                                        type:'line',
                                        stack: '总量',
                                        data:[120, 132, 101, 134, 90, 230, 210]
                                        },
                                        {
                                        name:'联盟广告',
                                        type:'line',
                                        stack: '总量',
                                        data:[220, 182, 191, 234, 290, 330, 310]
                                        },
                                        {
                                        name:'视频广告',
                                        type:'line',
                                        stack: '总量',
                                        data:[150, 232, 201, 154, 190, 330, 410]
                                        },
                                        
                                ]
                                                        })
                },
                getData(){
                        var url = this.$api+'Oper/GetLoadDate';
                        var oldThis = this;
                        this.$axios.get(url).then(function (response) {
                                oldThis.options2=[];
                                response.data.forEach(function(value,index){
                                        var row = {};
                                        row.value = index+1;
                                        row.label = value;
                                        oldThis.options2.push(row);
                                });
                                console.log(oldThis.options2);
                        }).catch(function (error) {
                        　　    alert(error);
                        });

                },
                loadcontainer(){
                        console.log(1);

                        var v = this.options2[this.value5-1];
                        console.log(v.label);
                },
        },

  }
</script>
<style scoped>
        .ensemble{
                display:flex;
                margin-top: 30px;
                justify-content: flex-start;
        }
        .flex_left .flex_left_t{
                height: 60px;
        }
        .flex_left .flex_left_t button,.flex_right button{height:40px;}
        .ipt_value{height:40px;line-height:40px;border-radius:5px;}
        .flex_left>div>label{
                color: #fff;
                font-size: 18px;font-weight: 700;line-height: 40px;display:inline-block;width:155px;text-align:right
        }
        .flex_right>a{
                width: 200px;height: 40px;line-height: 40px;color: #fff;background: #3366CC;border-radius: 5px;display: block;text-align: center;font-size: 16px;margin: 0 auto
        }
        .flex_left_C{
                display: flex;
                color: #fff;
        }
        .flex_left_C>div li{line-height:50px;}
        .flex_left_C>div label{
                font-size: 16px;font-weight: 700;width: 40px;text-align: center;display: inline-block;
        }
        .flex_left_C>div input{
                width: 150px;height: 30px;line-height: 30px;border-radius: 5px;color:#000;
        }
</style>