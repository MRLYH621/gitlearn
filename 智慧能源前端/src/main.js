// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import echarts from 'echarts'
import iView from 'iview'; 
import 'iview/dist/styles/iview.css';
import 'element-ui/lib/theme-chalk/index.css';

import Vant from 'vant';
import 'vant/lib/index.css';
import ElementUI from 'element-ui'
import router from './router'
import 'swiper/css/swiper.css';
import  "./assets/css/main.css";

import axios from 'axios'

Vue.prototype.$axios = axios

// 引用API文件
// import api from './api/index.js';
// 将API方法绑定到全局
Vue.prototype.$api = "http://localhost:15335/"

Vue.config.productionTip = false
Vue.use(ElementUI)
Vue.use(Vant)
Vue.use(iView);
// Vue.use(BaiduMap, {
//   ak: '3Xen8uvEedN2RgBON0qQMMpZTSPqhdq7'
// })
Vue.prototype.$echarts = echarts 


/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
