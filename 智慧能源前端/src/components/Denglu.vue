<template>
            <div id="home_login">
                    <div class="topContainer">
                            <div class="topContainer_left">
                                    <img src="../assets/images/logo_HB.png" alt="" style="width: 230px;height: 60px;">
                            </div>
                            <div class="topContainer_right">
                                <p><span>智慧能源多能互补系统认证评价平台</span></p> 
                                <p><span>Smart Energy Multi-Complementary System Certification Evaluation Platform</span></p>
                            </div>
                        </div>
                    <el-container>
                            <el-main>
                                    <div class="swiper-container">
                                            <div class="swiper-wrapper">
                                              <div class="swiper-slide">
                                                  <img src="../assets/images/1-1_u2.jpg" alt="">
                                              </div>
                                              <div class="swiper-slide">
                                                    <img src="../assets/images/1-2_u3.jpg" alt="">
                                              </div>
                                              <div class="swiper-slide">
                                                    <img src="../assets/images/1-3_u4.jpg" alt="">
                                              </div>
                                            </div>
                                            <div class="login">
                                                <div class="login_z">
                                                        <el-form :model="ruleForm"  ref="ruleForm" class="demo-ruleForm loginFrom">
                                                                <el-form-item >
                                                                    <el-input placeholder="用户名"  v-model="ruleForm.userName"></el-input>
                                                                </el-form-item>
                                                                <el-form-item>
                                                                    <el-input  type="password" v-model="ruleForm.password" placeholder="请输入密码" @keyup.enter.native="submitForm"></el-input>
                                                                </el-form-item>
                                                                    <el-button type="primary" class="submit"  @click="submitForm">登录</el-button>
                                                        </el-form>
                                                </div>
                                                    
                                            </div>
                                    </div>
                                   
                                    <div class="content" style="margin-top: 80px;overflow: hidden;">
                                        <div class="top_header" >
                                            <span>系统概览</span>
                                            <h3>SYSTEM OVERVIEW</h3>
                                        </div>
                                        <div class="top_center">
                                                <p><span style="font-size: 40px;font-weight: 700">实时监测系统数量：45个</span></p>
                                        </div>
                                        <div class="header_sd header_sd_float">
                                            <div class="header_sd_title">实施综合指数：</div>
                                            <div class="sd_fan courseLogo">
                                                    <div class="swiper-container1">
                                                            <div class="swiper-wrapper">
                                                              <div class="swiper-slide swiper1" v-for="item in prizeList">
                                                                    <div class="scroll-content" >
                                                                    <div>
                                                                         <p style="display: inline-block;color: #fff;font-size: 30px;font-weight: bold;margin-bottom: 5px;">{{item.city}}</p>
                                                                         <div class="scroll_flex">
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
                                                            </div>
                                                          </div>
                                                <!-- <div class="scroll-wrap">
                                                                <div class="scroll-content" :style="{ top }" @mouseenter="Stop()" 
                                                    @mouseleave="Up()">
                                                                    <div  v-for="item in prizeList">
                                                                         <p style="display: inline;color: #fff">{{item.city}}</p>
                                                                         <div class="scroll_flex">
                                                                             <div>
                                                                                 <p>接入系统：{{item.number}}</p>
                                                                                 <p>总容量：{{item.total}}</p>
                                                                             </div>
                                                                             <div>综合评价指数：{{item.index}}</div>
                                                                             <div>最优指数：{{item.optimal}}</div>
                                                                         </div>
                                                                     </div>
                                                       </div>
                                                    </div> -->
                                            </div>
                                        </div>
                                    </div>
                                    <div class="content" style="margin-top: 80px">
                                            <div class="top_header" >
                                                <span>平台功能</span>
                                                <h3>PLATFORM FUNCTION</h3>
                                            </div>
                                                <div class="top_center_img">
                                                    <img src="../assets/images/u70.png" alt="" style="display: block;margin: 0 auto;width: 1000px">
                                                </div>
                                     </div>
                                     <div class="content" style="margin-top: 80px">
                                            <div class="top_header" >
                                                <span>平台特色</span>
                                                <h3>PLATFORM  FEATURES</h3>
                                            </div>
                                            <div class="header_sd">
                                                    <div class="top_center_img">
                                                        <div>
                                                            <img src="../assets/images/适用范围广_u58.jpg" alt="">
                                                            <span>适用范围广</span>
                                                        </div>
                                                        <div>
                                                            <img src="../assets/images/技术模型精准_u59.jpg" alt="">
                                                            <span>评价模型精准</span>
                                                        </div>
                                                        <div>
                                                            <img src="../assets/images/标准化评估_u63.jpg" alt="">
                                                            <span>标准化评估</span>
                                                        </div>
                                                     </div>
                                                     <div  class="top_center_img">
                                                            <div>
                                                                    <img src="../assets/images/结果分析全面_u61.jpg" alt="">
                                                                    <span>结果分析全面</span>
                                                                </div>
                                                                <div>
                                                                    <img src="../assets/images/数据平台强大_u62.png" alt="">
                                                                    <span>数据平台强大</span>
                                                                </div>
                                                                <div>
                                                                    <img src="../assets/images/界面交互简单_u60.png" alt="">
                                                                    <span>界面交互简单</span>
                                                                </div>     
                                                     </div>
                                            </div>
                                     </div>
                                     <div class="content" style="margin-top: 80px">
                                        <div class="top_header" >
                                            <span>联系我们</span>
                                            <h3>CONTACT US</h3>
                                        </div>
                                        <div class="header_sd header_sd_contact">
                                                <div>
                                                    <div class="wx_img" style="float: left;margin-right: 30px;">
                                                        <img src="../assets/images/u53.png" alt="">
                                                        <span style="display: block;color: #fff;text-align: center;font-size: 18px;">微信公众号</span>
                                                    </div>
                                                    <div class="adress">
                                                        <p>地址：北京市海淀区王庄路1号清华同方科技广场</p>
                                                        <p>电话：010-8237899</p>
                                                        <p>邮箱：microgrid@bicorona.com</p>
                                                        <p>网址：www.bjcorona.com</p>
                                                    </div>
                                                </div>
                                                <div> 
                                                        <!-- //地图的容器 -->
                                                    　  <div id="map_canvas" class="allmap"></div>    
                                                    
                                                </div>
                                        </div>
                                 </div>
                            </el-main>
                            <el-footer>
                                <div id="footer">
                                    <p>北京科诺伟业科技股份有限公司版权所有 ©2019</p>
                                    <p>Beijing Corona Science & Technology Co., Ltd. All Rights Reserved</p>
                                </div>
                            </el-footer>
                          </el-container>
                        
                        
            </div>
   
    
   
</template>
<script>
   import Swiper from 'swiper';
export default {
  name: 'HelloWorld',
  data () {
    return {
        ruleForm: {
				userName: '', //用户名
				password: ''  //密码
     		},	
             prizeList: [
              { name: '城轨采购网',city:"北京市 北京市",number:"11111",total:"11111",index:"11111",optimal:"11111"},
              { name: '天津地铁电子采购平台',city:"天津市  天津市",number:"22222" ,total:"222222",index:"222222",optimal:"22222"},
              { name: '南昌地铁', city:"河北省 保定市",number:"3333",total:"33333",index:"33333",optimal:"33333"},
              { name: '南昌地铁', city:"山东省 济宁市",number:"4444",total:"44444",index:"44444",optimal:"44444"},
            ],
            activeIndex: 0,
            intnum:undefined,
            userlocation: { lng: "116.345421", lat: "40.005043" },
            map : {},
             mk: {}
    }
  },
  computed: {},
 
created() {},

  mounted(){
    this.$nextTick(function() {
     this.drawMap();
    });
     new Swiper ('.swiper-container', {
        loop: true,
        autoplay:true,
    })
    var swiper = new Swiper('.swiper-container1', {
      effect: 'flip',
      grabCursor: true,
      loop: true,
      autoplay:true,
     
    });
  },
  methods:{
    submitForm(){
        this.$router.push({ path:'/Ensemblemonitoring'  })
    },
    //地图
    //  ----------------------------------------
    drawMap() {
        this.map = new BMap.Map("map_canvas");                // 创建地图实例
        this.map.addControl(new BMap.NavigationControl());           // 启用放大缩小 尺
        this.map.enableScrollWheelZoom();
        var point = new BMap.Point(this.userlocation.lng, this.userlocation.lat);  // 创建点坐标 
        this.map.centerAndZoom(point, 13);                 // 初始化地图，设置中心点坐标和地图级别 
        var marker = new BMap.Marker(point);        // 创建标注   
        this.map.addOverlay(marker);                     // 将标注添加到地图中
        this.getMarker(point)      //label
    },
    getMarker (point) {
                this.mk = new BMap.Marker(point); 
                this.getAddress(point);
                this.map.addOverlay(this.mk);//把点添加到地图上 
                this.map.panTo(point);
     },
      //获取地址信息，设置地址label
      getAddress(point){
            var gc = new BMap.Geocoder();
             
            gc.getLocation(point, (rs)=>{
                var addComp = rs.addressComponents;
                var address =  addComp.province +  addComp.city + addComp.district + addComp.street + addComp.streetNumber+"号";//获取地址
                 console.log()
                //画图 ---》显示地址信息
                var label = new BMap.Label(address,{offset:new BMap.Size(20,-10)});
                this.map.removeOverlay(this.mk.getLabel());//删除之前的label
                // this.address_detail = address;
                this.mk.setLabel(label);
                 
             });
              
        },
    //  ----------------------------------------
  },
 
}
</script>
<style scoped>
    .allmap{ 
 height: 200px; 
 overflow: hidden; 
} 
    #home_login{
        width:100%;
		   position: relative;
		   left: 0px;
		   right:0px;
		   top:0px;
		   bottom: 0px;  
        background: rgb(22,89,155)
    }
    .topContainer{
        width: 100%;
        height: 60px;
        background: #4C76C7;
        position: fixed;
        z-index: 200;
        overflow: hidden;
    }
    .topContainer_left{
        float: left;
    }
    .topContainer_right{
        color: #FFF;
        font-size: 18px;
        line-height: 30px;
    }
    .swiper-container {
      width: 100%;
      height: 100%;
      position: relative;
    }
    .swiper-slide {
      text-align: center;
      font-size: 18px;
      background: #fff;

      /* Center slide text vertically */
      display: -webkit-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-box-pack: center;
      -ms-flex-pack: center;
      -webkit-justify-content: center;
      justify-content: center;
      -webkit-box-align: center;
      -ms-flex-align: center;
      -webkit-align-items: center;
      align-items: center;
    }
    .swiper-slide>img{
        width: 100%;
        height: 600px;
        display: block;
    }
    .login{
        width: 300px;
        height: 300px;
        background-color:rgba(244,251,251,0.47);
        border: 1px solid #ccc;
        position: absolute;
        top: 170px;
        right: 200px;
        z-index: 200;
        padding: 10px;
    }
    .submit{
        width: 100%;
    }
    .top_header,.top_center{
        color: #fff;
        margin: 0 auto;
        text-align: center;
        width: 50%;
        padding: 20px 0
    }
    .top_header>span{
        font-size: 50px;
        line-height: 40px;
        font-weight: 700
    }
    .top_header>h3{
        font-size: 30px;
        line-height: 40px;
    }
    .courseLogo{
    height: 300px;width: 70%;
    float: left;
    margin-top: 1px;
    position: relative;
    box-sizing: border-box;
    perspective: 800px;
}
.header_sd_title{
    color: #fff;
    font-size: 30px;
    font-weight: bold;
    float: left;
    line-height: 300px;
}
.top_center_img{
    display: flex;
    margin: 20px 0;
}
.top_center_img>div{
    flex: 1;
    position: relative;
}
.top_center_img>div>img{
    width: 200px;
    height: 200px;
    display: block;
    margin: 0 auto
}
.top_center_img>div>span{
    background: #1F4B91;
    height: 30px;
    line-height: 30px;
    width: 200px;
    font-size: 16px;
    display: block;
    position: absolute;
    top: 170px;
    left: 118px;
    color: #FFF;
    text-align: center
}
.header_sd_contact{
    display: flex;
}
.header_sd_contact>div{
    flex: 1
}
.header_sd_contact .adress>p{
    line-height: 30px;
    color: #fff;
    font-size: 18px;
}
#footer{
    background: #3366CC;
    height: 60px;
    width: 100%;
    color: #fff;
    font-size: 22px;text-align: center

}
#footer>p{
    line-height: 30px
}
.scroll-wrap{
    height: 200px;
    overflow: hidden;
}
.scroll-content{
    position: relative;
    transition: top .5s;
    margin-top: 20px;
}
.scroll-content div .scroll_flex{
    display: flex;
    margin-top: 50px;
}
.scroll-content div .scroll_flex>div{
    flex: 1;
    color: #fff;
    font-size: 18px;
    line-height: 20px;
    width: 260px;
    height: 110px;
    border: 1px solid #ccc;
    background: red;
    margin: 0 20px 0 20px;
    font-size: 19px;
    font-weight: 700;
}
.scroll-content div .scroll_flex>div:nth-child(1){
    padding-top: 20px;
}
.scroll-content div .scroll_flex>div:nth-child(2),.scroll-content div .scroll_flex>div:nth-child(3){
    display: flex;
            align-items: center; /*定义body的元素垂直居中*/
            justify-content: center; /*定义body的里的元素水平居中*/
}
.scroll-content div .scroll_flex>div.flex_start>p{
    line-height: 35px;
    align-items: center 
}
</style>
<style>
     /* .swiper-container1 {
      width: 300px;
      height: 300px;
      padding: 50px;
    } */
    .swiper-slide1 {
      background-position: center;
      background-size: cover;
     
      /* width: 300px;
      height: 300px; */
    }
    .swiper1{ background: none !important;}
    BMap_cpyCtrl {
        display: none;
    }
    .anchorBL {
        display: none;
    }

</style>
