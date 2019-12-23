<template>
    <div>
    <div class="JSQX-Bov">
        <div class='JSQX-Bov-middle'>
            <!-- 第二行第一个开始 -->
            <div class='JSQX-Bov-middle-cell'>
                <div class="JSQX-Bov-top-cell-title">
                    <i class="JSQX-Bov-top-cell-title-i">角色权限编辑</i>
                </div>
                 <div class='JSQXBtn'>
                 <!-- <button type="button" @click="save" class="button-white" style="padding:0 10px;line-height: 30px" >保存</button> -->
                 <button @click="back" type="button" class="button-white select" style="width: 85px;margin-right: 5px;margin-left: 5px;line-height: 30px">返回上一页 </button>
                </div>
                <div style='width:100%;height:609px' id='yongnengbi'>
                     <div class='JSQX-Bov-top-cell2'>
                         <div class='JSQX-Bov-top-cell2-2' >
                            <div class='JSQX-Bov-top-cell2-2Cell'>
                                账户名称：<input type="text" v-model="UserName"  placeholder="请输入账户名称" style='width:100px;height:70%'>
                            </div>
                            <div v-if="UserID == -1" class='JSQX-Bov-top-cell2-2Cell'>
                                账户密码：<input type="password" v-model="UserPassword"  placeholder="请输入账户密码"  style='width:100px;height:70%'>
                            </div>
                            <div class='JSQX-Bov-top-cell2-2Cell'>
                                用户名称：<input type="text" v-model="UserFullName" placeholder="请输入用户名称" style='width:100px;height:70%'>
                            </div>
                            <div class='JSQX-Bov-top-cell2-2Cell'>
                                角色信息：
                                <select style='width:100px;height:70%' v-model="Role" ><!--@change="selectRole"-->
                                    <option :value="item.RoleID" v-for="item in selectOne">{{item.RoleName}}</option>      
                                </select>
                            </div>
                            <div class='JSQX-Bov-top-cell2-2Cell'>
                                手机号码：<input type="text" v-model="UserPhone" placeholder="请输入手机号码" style='width:100px;height:70%'>
                            </div>
                            <div class='JSQX-Bov-top-cell2-2Cell'>
                                邮箱地址：<input type="text" v-model="UserEmail" placeholder="请输入邮箱地址"  style='width:100px;height:70%'>
                            </div>
                         </div>
                    </div>
                </div>
            </div>
            </div>
        </div>
    </div>
    </div>
</template>
<script>
    export default{
        data(){
            return{
                UserName:'',
                UserPassword:'',
                UserFullName:'',
                Role:'',
                UserPhone:'',
                UserEmail:'',
                UserID:-1,
                selectOne:[
                    { RoleID:0,RoleName:'admin'},
                    { RoleID:1,RoleName:'admin'},
                    { RoleID:2,RoleName:'admin'},
                ]
            }
        },
        methods:{
            back(){
                this.$router.go(-1);//返回上一层
            },
        }

    }
</script>
<style scoped>
    input{
        color: #000
    }
    li{
        padding:0px;
        margin: 0px;
        list-style:none;
    }
    .JSQX-Bov,.JSQX-Bov-top,.JSQX-Bov-middle{
        width: 100%;
    
    }
    .JSQX-Bov-top,.JSQX-Bov-middle{
        display: flex;
        justify-content:space-between;
        padding:5px;
        box-sizing: border-box
    }


    .JSQX-Bov-middle-cell{
            width:100%;
        /* box-shadow:inset 2px 2px 1px RGB(30,30,30), 2px 2px 1px RGB(30,30,30); */
        border-radius: 6px;
        /* background-color:RGB(43,50,58); */
        padding:5px;
        box-sizing: border-box
        
    } 
    .JSQX-Bov-top-cell-title{
        width:100%;
        height: 30px;
        /* background-color:pink; */
        box-sizing: border-box
    }
    .JSQX-Bov-top-cell-title-i{
        height: 30px;
        line-height: 30px;
        float:left;
        color:white;
        font-weight: 700
    }

    .JSQXBtn{
        width: 100%;
        padding:10px;
        box-sizing: border-box;
        display: flex;
        justify-content: flex-end;
    }
    .JSQX-Bov-top-cell2{
        width: 100%;display: flex;justify-content: flex-start
    }
    .JSQX-Bov-top-cell2-2{
        width:900px;margin:0 auto;margin-top:10px;display: flex;justify-content: flex-start;flex-wrap: wrap
    }
    .ivu-tree{
        margin: 0 auto!important
    }
    .JSQX-Bov-top-cell2-2>div{
    width:100%x;height:35px;line-height:35px;font-size:10px;color:white;margin: 0 5px;text-align: center
    }
    .success{
        background-color:RGB(25,190,107);color:white
    }
    .JSQX-Bov-top-cell2-2Cell{
        width: 100%;
        height: 30px;;
    }
</style>