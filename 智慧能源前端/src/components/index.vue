<template>
    <el-container>
        <el-header >
          <div class="topContainer">
                <div class="topContainer_left">
                   <img src="../assets/images/logo_HB.png" alt="" style="width: 230px;height: 60px;float:left">
                    <span class="date-time">  {{gettime}}</span>
                </div>
                <div class="topContainer_right"> 
                      <div class="top_3D">
                         <div class="swiper-container3">
                            <div class="swiper-wrapper">
                              <div class="swiper-slide swiper" v-for="item in prizeList">
                                 <div>{{item.city}}</div>
                                 <div class="flex_start">
                                     <p>接入系统：{{item.number}}</p>
                                     <p>总容量：{{item.total}}</p>
                                 </div>
                                 <div>综合评价指数：{{item.index}}</div>
                                 <div>最优指数：{{item.optimal}}</div>
                              </div>
                            </div>
                          </div>
                    </div>
                    <div>
                      <el-dropdown style="cursor: pointer;color: #fff;">
                            <span class="el-dropdown-link" style="font-weight: bold;font-size: 18px" title="个人中心" >
                                <Icon type="ios-contact-outline" id="contact"/>
                              FullName<i class="el-icon-arrow-down el-icon--right"></i>
                            </span>
                            <el-dropdown-menu slot="dropdown">
                              <el-dropdown-item><div @click="password" >修改密码</div></el-dropdown-item>
                              <el-dropdown-item><div @click="denglu" >退出登录</div></el-dropdown-item>
                            </el-dropdown-menu>
                          </el-dropdown>
                    </div>
                    
                   
                </div>
          </div>
            
          </el-header>
          <el-container>
              <el-aside width="200px" style="background-color: rgb(14, 91, 224)">
                  <div class="header" v-for="(item,index) in headerData" :key="item.name">
                      <ul v-if="item.key">
                          <!-- 循环数据在点击调用changeli方法时将当前索引和本条数据传进去,并使用当前数据show的bool值添加或移除样式 @mouseleave="navLeave(index)" --> 
                          <li :class="[{active:item.show}]" @click="changeli(index,item)"  >
                              <i class="el-icon-setting"></i>
                              <!-- 在这里打印出boll值方便查看 -->
                              <span>{{item.name}}</span>
                                  <ul v-show="item.show">  
                                      <!-- 循环二级菜单数据并使用.stop阻止冒泡 -->
                                      <li v-for="(a,index) in item.list" v-on:click.stop="doThis(index)" class="navmenue_two"> 
                                        <router-link :to="a.path" active-class="active"  ><i class="icon iconfont">*</i>{{a.name}}</router-link></li>
                                 </ul> 
                            
                          </li>
                      </ul>
                      <ul v-else>
                          <!-- 循环数据在点击调用changeli方法时将当前索引和本条数据传进去,并使用当前数据show的bool值添加或移除样式 @mouseleave="navLeave(index)" --> 
                          <li :class="[{active:item.show}]" @click="changeli(index,item)"  >
                              <i class="el-icon-setting"></i>
                              <!-- 在这里打印出boll值方便查看 -->
                              <router-link :to="item.path" active-class="active" tag="span"> {{item.name}}</router-link>
                              
                            
                          </li>
                      </ul>
                  </div>
                </el-aside>
              <el-main>
                 <router-view/>
              </el-main>
            </el-container>
           
           
          </el-container>
        </template>  
<script>
  import Swiper from 'swiper';
  export default {
    data() {
      const item = {
        date: '2016-05-02',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1518 弄'
      };
      return {
        gettime:"",//当前时间
          prizeList: [
              { name: '城轨采购网',city:"北京市 北京市",number:"11111",total:"11111",index:"11111",optimal:"11111"},
              { name: '天津地铁电子采购平台',city:"天津市  天津市",number:"22222" ,total:"222222",index:"222222",optimal:"22222"},
              { name: '南昌地铁', city:"河北省 保定市",number:"3333",total:"33333",index:"33333",optimal:"33333"},
              { name: '南昌地铁', city:"山东省 济宁市",number:"4444",total:"44444",index:"44444",optimal:"44444"},
            ],
    headerData: [{
                    name: '能源监测',
                    path:"/Ensemblemonitoring",
                    "key": false,
                    show: false
                }, {
                    name: '运行评估',
                    path:"/Centralizeddisplay",
                    list: [
                      {name:"集中展示",path:"/Centralizeddisplay"},
                      {name:"在线评估",path:"/Onlineassessment"},
                    ],
                    "key": true,
                    show: false
                }, {
                    name: '运行优化',
                    path:"Investmentdecision",
                    list: [
                      {name:"投资决策",path:"/Investmentdecision"},
                      {name:"优化运行",path:"/Optimaloperation"},
                      {name:"仿真数据",path:"/Simulationdata"},
                    ],
                    "key": true,
                    show: false
                }, {
                    name: '平台设置',
                    path:"Usermanagement",
                    list: [
                      {name:"用户管理",path:"/Usermanagement"},
                      {name:"评价指标设置",path:"/Evaluationindexsetting"},
                      {name:"评估模型管理",path:"/Assessmentmodelmanagement"},
                    ],
                    "key": true,
                    show: false
                },],
      }
    },
    created() {
        this.currentTime();    
      },
      mounted(){
         var swiper = new Swiper('.swiper-container3', {
            direction: 'vertical',
            effect: 'flip',
            grabCursor: true,
             loop: true,
            autoplay:true,
    });
    },
    methods: { 
        goTo(path) {
        this.$router.replace(path);
      },
      handleOpen(key, keyPath) {
        console.log(key, keyPath);
      },
      handleClose(key, keyPath) {
        console.log(key, keyPath);
      },
      currentTime(){
          setInterval(this.getTime,5000)
        },
      getTime:function(){
        var _this = this;
        let yy = new Date().getFullYear();
        let mm = new Date().getMonth()+1;
        let dd = new Date().getDate();
        let hh = new Date().getHours();
        let mf = new Date().getMinutes()<10 ? '0'+new Date().getMinutes() : new Date().getMinutes();
        let ss = new Date().getSeconds()<10 ? '0'+new Date().getSeconds() : new Date().getSeconds();
        // _this.gettime = yy+'/'+mm+'/'+dd+' '+hh+':'+mf+':'+ss;
        _this.gettime = yy+'/'+mm+'/'+dd+' '+hh+':'+mf;
      },
       denglu:function(){
            // localStorage.setItem("checked",false);
          	this.$router.push({path: '/'});
        },
        password:function(){
          	this.$router.push({path: '/UpdatePwd'});
        },
        changeli: function(ind, item) {
                // 先循环数据中的show将其全部置为false,此时模板里的v-if判断生效关闭全部二级菜单,并移除样式
                this.headerData.forEach(i => {
                    // 判断如果数据中的headerData[i]的show属性不等于当前数据的show属性那么headerData[i]等于false
                    if (i.show !== this.headerData[ind].show) {
                        i.show = false;
                    };
                });
                // 取反(true或false)
                item.show = !item.show;
                console.log(item.name)
            },
            doThis(index){
                console.log(index)
            },
            navEnter: function(index) {
          this.headerData[index].show = true;
        },
        navLeave: function(index) {
          this.headerData[index].show = false;
        },
    }
  };

</script>
<style scoped>
  .header {
  background-color: 	#000;
  color: #ffffff;
  font-size: 16px;font-weight: 700
}
.header > ul {
  width: 100%;
}
/* @include clearfix; */
.header > ul > li {
  width: 100%;
  cursor: pointer;
  color:#fff;
  text-align: center;
  line-height: 60px;
}
.header > ul > li:hover {
  color: #03ccbb;
}
.header > ul > li > ul {
  width: 100%;
  /* background: #4169E1; */
  background: #000;
  /* border: 2px solid #ccc;
  border-radius: 5px; */
}
.header > ul > li > ul li:hover {
  /* background: #1E90FF; */
  color: #03ccbb;
}
.header > ul .active {
  /* background-color: #1E90FF; */
  color: #03ccbb;
}
.navmenue_two{font-size: 14px;font-weight: normal}
.navmenue_two>a{color: #fff;}
.navmenue_two>a.active{
  /* background: 	#1E90FF; */
  color: #03ccbb;
  /* color: #f90; */
  display: block
}
textarea {
  width: 400px;
  height: 300px;
  font-size: 12px;
}
  .el-header {
    background-color: #B3C0D1;
    color: #333;
    line-height: 60px;
  }
   .date-time{color:#fff;font-size:18px;font-weight: 700;line-height: 60px;}
  .el-aside {
    color: #333;
  }
  .topContainer_left{float:left;width:33%}
  .topContainer_right{float:right;width:67%;display:flex;justify-content:flex-start;color:#fff}
  .top_3D{width:720px;height:60px;display:block;line-height:60px}
  .swiper{display:flex;color:#fff;font-size:16px;font-weight:700;}
  .swiper div{flex:1}
  /* .swiper>div:nth-child(2){
    padding-top: 20px;
} */
.swiper>div:nth-child(3),.swiper>div:nth-child(4){
    display: flex;
            align-items: center; /*定义body的元素垂直居中*/
            justify-content: center; /*定义body的里的元素水平居中*/
}
.swiper>div.flex_start>p{
    line-height: 35px;
    align-items: center 
}
 #contact{
        font-size: 24px
  }
</style>
<style>
  .ivu-table .demo-table-info-row td{
    background-color: #2db7f5;
    color: #fff;
}
.ivu-table .demo-table-error-row td{
    background-color: #ff6600;
    color: #fff;
}
.ivu-table td.demo-table-info-column{
    background-color: #2db7f5;
    color: #fff;
}
.ivu-table .demo-table-info-cell-name {
    background-color: #2db7f5;
    color: #fff;
}
.ivu-table .demo-table-info-cell-age {
    background-color: #ff6600;
    color: #fff;
}
.ivu-table .demo-table-info-cell-address {
    background-color: #187;
    color: #fff;
}
.swiper-container3{height:60px;}
/* .swiper-container3 .swiper-slide{height:100px;} */
</style> 







