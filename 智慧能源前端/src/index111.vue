<template>
      <el-container class="app-default-layout">
        <el-aside class="app-left-nav bg-gredient-indigo" :style="{'max-width': drawer ? '70px' : '300px'}">
          <el-menu
            :default-active="activeIndex"
            @select="handleSelect"
            router
            class="el-menu-vertical-nav color-white"
            text-color="#FFFFFF"
            active-text-color="#FFFFFF"
            :background-color="drawer ? '#14191F' : 'transparent'"
            :show-timeout="50"
            :hide-timeout="50"
            :collapse="drawer">
            <template v-for="(subMenu, subIndex) in navList">
              <!--只有一级菜单-->
              <el-menu-item v-if="!subMenu.children" :key="subIndex" :index="subMenu.to">
                <v-icon color="#FFFFFF" class="mr-1" v-html="subMenu.icon"></v-icon>
                <span slot="title">{{ subMenu.title }}</span>
              </el-menu-item>
              <!-- 多级菜单 -->
              <el-submenu v-else :index="subIndex + ''" :key="subIndex">
                <template slot="title">
                  <i class="el-icon-location"></i>
                  <span>{{ subMenu.title }}</span>
                </template>
                <el-menu-item-group>
                  <span slot="title" v-show="drawer">{{ subMenu.title }}</span>
                  <template v-for="(menu, index) in subMenu.children">
                    <el-menu-item
                      v-if="(menu.title === 'Projects' && isAdminOrLTE) || menu.title !== 'Projects'"
                      :index="menu.to"
                      :key="index"
                    >
                      <v-icon color="#FFFFFF" class="mr-1" v-html="menu.icon"></v-icon>
                      {{ menu.title }}
                    </el-menu-item>
                  </template>
                </el-menu-item-group>
              </el-submenu>
            </template>
          </el-menu>
        </el-aside>
        <el-container class="app-container-box" :style="{'padding-left': drawer ? '70px' : '300px'}">
          <el-header class="d-flex justify-space-between align-center app-header-nav" :style="{'left': drawer ? '70px' : '300px'}">
            <el-button class="side-nav-btn header-nav-btn" :icon="drawer ? 'el-icon-s-unfold side-nav-icon' : 'el-icon-s-fold side-nav-icon'" circle @click="changeSideStatus()"></el-button>
            <div class="d-flex justify-end align-center">
              <v-icon style="max-width: 24px;" class="mr-2">account_circle</v-icon>
              <!-- {{ $store.state.auth.user.user_name }} -->
              <el-button class="logout-btn header-nav-btn ml-2" circle @click="logout()">
                <v-icon>exit_to_app</v-icon>
              </el-button>
            </div>
          </el-header>
          <el-main class="bg-gredient-lightBlue" data-app="true" style="margin-top: 45px;">
              <nuxt />
          </el-main>
          <el-footer style="height: 26px; padding-top: 3px;">
            <p style="text-align: center;" class="mb-0">ARES &copy; 2019</p>
          </el-footer>
        </el-container>
      </el-container>
    </template>
    
    <script>
    export default {
      data () {
        return {
          drawer: false,
          navList: [
            { icon: 'apps', title: '4444', to: '/Ensemblemonitoring' },
            { icon: 'description', title: '5555', to: '/Systemdetection' },
            // { icon: 'date_range', title: 'Plans', to: '/plans', checkProject: true },
            { icon: 'date_range', title: 'Plans', to: '/plans' },
            // { icon: 'event_note', title: 'Memo', to: '/memos', checkProject: true },
            { icon: 'assignment', title: 'Engineer', to: '/engineer' },
            { icon: 'assignment', title: 'HR', to: '/hr' },
            { icon: 'bug_report', title: 'Tracking', to: '/trackings' },
            { icon: 'view_list', title: 'Resources', to: '/resources' },
            { icon: 'event_note', title: '1111', to: `/Datumparameter` },
            // { icon: 'folder_open', title: 'FW', to: '/fws', checkProject: true }
            {
              icon: 'show_chart',
              title: 'ARES Rept.',
              children: [
                { icon: 'list_alt', title: '2222', to: '/Assessmentmodelmanagement' },
                { icon: 'list_alt', title: '3333 Classification', to: '/Evaluationindexsetting' },
                { icon: 'storage', title: 'Projects', to: '/projectares' },
                { icon: 'poll', title: 'Defect Flight Pattern', to: '/defectFlightPattern' }
              ]
            },
            {
              icon: 'account_circle',
              title: 'Admin',
              children: [
                // { icon: 'event_note', title: 'Projects', to: '/projects' },
                { icon: 'view_agenda', title: 'Progress', to: '/progress' },
                { icon: 'people', title: 'Customers', to: '/customers' },
                { icon: 'assessment', title: 'Patterns', to: '/patterns' },
                { icon: 'face', title: 'Users', to: '/users' },
                { icon: 'local_offer', title: 'Tags', to: '/tags' },
                { icon: 'timeline', title: 'Timeline', to: '/timeline' },
                { icon: 'assignment', title: 'Resource Types', to: '/resourcetypes' },
                { icon: 'schedule', title: 'Schedule', to: '/schedule' }
              ]
            }
          ],
          activeIndex: '/'
        }
      },
      watch: {
        '$route' () {
          this.handleSelect(this.activeIndex)
        }
      },
      methods: {
        changeSideStatus () {
          this.drawer = !this.drawer
        },
        handleSelect (index) {
          this.activeIndex = index
        }
      },
      mounted () {
        this.activeIndex = this.$route.matched[0].path || '/'
      }
    }
    </script>
    
    <style lang="" scoped>
   .app-default-layout {
  min-width: 100vh;
}
.app-default-layout .app-left-nav {
  position: fixed;
  left: 0;
  top: 0;
  bottom: 0;
  z-index: 100;
  overflow-x: hidden;
  overflow-y: auto;
  transition: all .1s;
}
.app-default-layout .el-menu-vertical-nav {
  width: 70px;
  border: 0;
}
.app-default-layout .el-menu-vertical-nav .el-menu-item:hover,
.app-default-layout .el-menu-vertical-nav .el-submenu .el-submenu__title:hover {
  background-color: rgba(255, 255, 255, 0.08) !important;
}
.app-default-layout .el-menu-vertical-nav .el-menu-item.is-active {
  background-color: rgba(255, 255, 255, 0.2) !important;
}
.app-default-layout .el-menu-vertical-nav .el-menu-item-group__title {
  padding-top: 0;
  padding-bottom: 0;
}
.app-default-layout .el-menu-vertical-nav:not(.el-menu--collapse) {
  width: 300px;
}
.app-default-layout .app-container-box {
  transition: all .1s;
  min-height: 100vh;
}
.app-default-layout .app-header-nav {
  position: fixed;
  top: 0;
  right: 0;
  height: 45px !important;
  z-index: 100;
  background-color: #f5f5f5;
  transition: all .1s;
  box-shadow: 0 2px 4px -1px rgba(0, 0, 0, 0.2), 0 4px 5px 0 rgba(0, 0, 0, 0.14), 0 1px 10px 0 rgba(0, 0, 0, 0.12);
}
.app-default-layout .header-nav-btn {
  border: 0;
  padding: 0;
  background: transparent;
}
.app-default-layout .header-nav-btn:focus {
  background: transparent;
  color: #606266;
}
.app-default-layout .header-nav-btn:hover {
  background: #DCDCDC;
  color: #606266;
}
.app-default-layout .side-nav-btn {
  width: 35px;
  height: 35px;
  max-width: 35px;
}
.app-default-layout .side-nav-btn i.side-nav-icon {
  font-size: 26px;
}
.app-default-layout .logout-btn {
  width: 30px;
  height: 30px;
  max-width: 30px;
}
.el-menu--vertical .el-menu-item:hover {
  background-color: rgba(255, 255, 255, 0.1) !important;
}
.el-menu--vertical .el-menu-item.is-active {
  background-color: rgba(255, 255, 255, 0.2) !important;
}
    </style>