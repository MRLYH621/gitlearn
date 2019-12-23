import Vue from 'vue'
import Router from 'vue-router'
import index from '@/components/index'
import Denglu from '@/components/Denglu'
import Ensemblemonitoring from '@/components/Energymonitoring/Ensemblemonitoring'
import editing from '@/components/Energymonitoring/editing'
import Systemdetection from '@/components/Energymonitoring/Systemdetection'  //系统检测
import Systeminformation from '@/components/Energymonitoring/Systeminformation'  //系统信息
import Deviceinformation from '@/components/Energymonitoring/Deviceinformation'  //设备信息
import Centralizeddisplay from '@/components/Operationalevaluation/Centralizeddisplay'
import Systemevaluation from '@/components/Operationalevaluation/Systemevaluation' //系统评估
import Onlineassessment from '@/components/Operationalevaluation/Onlineassessment' // 在线评估
import Assessmentreport from '@/components/Operationalevaluation/Assessmentreport' //系统报告
import Investmentdecision from '@/components/Operationoptimization/Investmentdecision' //投资决策
import Optimaloperation from '@/components/Operationoptimization/Optimaloperation'//优化运行
import Sensitivityanalysis from '@/components/Operationoptimization/Sensitivityanalysis'//敏感性分析
import Sensitivityanalysisreport from '@/components/Operationoptimization/Sensitivityanalysisreport'//敏感性分析报告
import Investmentreport from '@/components/Operationoptimization/Investmentreport'//分析报告
import Simulationdata from '@/components/Operationoptimization/Simulationdata'//仿真数据
import Energysupply from '@/components/Operationoptimization/Energysupply'//仿真数据-供能
import Load from '@/components/Operationoptimization/Load'//仿真数据-负荷
import Assessmentmodelmanagement from '@/components/Platformsetup/Assessmentmodelmanagement' //评估模型管理
import Evaluationindexsetting from '@/components/Platformsetup/Evaluationindexsetting' //评价指标设置
import Economicparameter from '@/components/Platformsetup/Economicparameter' //经济参数
import Datumparameter from '@/components/Platformsetup/Datumparameter' //基准参数
import Timeallocation from '@/components/Platformsetup/Timeallocation' //时间配置
import Usermanagement from '@/components/Platformsetup/Usermanagement'  //用户管理
import JSQX from '@/components/Platformsetup/JSQX'  //角色信息
import UpdateUser from '@/components/Platformsetup/UpdateUser'  //角色信息
import UpdatePwd from '@/components/Platformsetup/UpdatePwd'  //修改密码


Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'Denglu',
      component: Denglu
    },
    
    {
      path: '/index',
      name: 'index',
      component: index, //导航
      children:[
        {
          path: '/Ensemblemonitoring',
          name: 'Ensemblemonitoring',
          component: Ensemblemonitoring //集合监测
        }, 
        {
          path: '/editing',
          name: 'editing',
          component: editing //集合监测
        }, {
          path: '/Systemdetection',
          name: 'Systemdetection',
          component: Systemdetection //集合监测
        },{
          path: '/Systeminformation',
          name: 'Systeminformation',
          component: Systeminformation //系统信息
        },{
          path: '/Deviceinformation',
          name: 'Deviceinformation',
          component: Deviceinformation //设备信息
        }, {
          path: '/Centralizeddisplay',
          name: 'Centralizeddisplay',
          component: Centralizeddisplay //集中展示
        },
        {
          path: '/Systemevaluation',
          name: 'Systemevaluation',
          component: Systemevaluation //系统评估
        },{
          path: '/Onlineassessment',
          name: 'Onlineassessment',
          component: Onlineassessment // 在线评估
        },
        {
          path: '/Assessmentreport',
          name: 'Assessmentreport',
          component: Assessmentreport //系统报告
        }, {
          path: '/Investmentdecision',
          name: 'Investmentdecision',
          component: Investmentdecision //投资决策
        },{
          path: '/Investmentreport',
          name: 'Investmentreport',
          component: Investmentreport //分析报告
        }, {
          path: '/Optimaloperation',
          name: 'Optimaloperation',
          component: Optimaloperation, //优化运行
        }, {
          path: '/Sensitivityanalysis',
          name: 'Sensitivityanalysis',
          component: Sensitivityanalysis //敏感性分析
        }, {
          path: '/Sensitivityanalysisreport',
          name: 'Sensitivityanalysisreport',
          component: Sensitivityanalysisreport //敏感性分析报告
        }, {
          path: '/Simulationdata',
          name: 'Simulationdata',
          component: Simulationdata //仿真数据
        },{
          path: '/Energysupply',
          name: 'Energysupply',
          component: Energysupply //仿真数据-供能
        },{
          path: '/Load',
          name: 'Load',
          component: Load //仿真数据-负荷
        },  {
          path: '/Assessmentmodelmanagement',
          name: 'Assessmentmodelmanagement',
          component: Assessmentmodelmanagement //评估模型管理
        }, {
          path: '/Evaluationindexsetting',
          name: 'Evaluationindexsetting',
          component: Evaluationindexsetting //评价指标设置
        }, {
          path: '/Economicparameter',
          name: 'Economicparameter',
          component: Economicparameter //经济参数
        },{
          path: '/Datumparameter',
          name: 'Datumparameter',
          component: Datumparameter //经济参数
        },{
          path: '/Timeallocation',
          name: 'Timeallocation',
          component: Timeallocation //时间配置
        },{
          path: '/Usermanagement',
          name: 'Usermanagement',
          component: Usermanagement //用户管理
        },{
          path: '/JSQX',
          name: 'JSQX',
          component: JSQX //角色权限
        },{
          path: '/UpdateUser',
          name: 'UpdateUser',
          component: UpdateUser // 角色信息 
        }, {
            path: '/UpdatePwd',
            name:'UpdatePwd',
            component: UpdatePwd//个人中心-mimaxiugai
        }, 
      ]
    },
  ]
})
