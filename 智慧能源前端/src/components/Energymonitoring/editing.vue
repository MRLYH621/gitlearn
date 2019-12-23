<template>
    <div>
        <div style="height: 60px;">
                <button @click="back()"  class="goback">返回</button>
        </div>
        <div class="flex_top">
            <ul>
                <li>设备名称</li>
                <li>设备类型</li>
                <li>设备型号</li>
                <li>安装位置</li>
                <li>厂家</li>
                <li>厂家联系方式</li>
            </ul>
            <ul class="text_S">
                    <li><input type="text" v-model="name"></li>
                    <li><input type="text" v-model="type"></li>
                    <li><input type="text" v-model="model"></li>
                    <li><input type="text" v-model="address"></li>
                    <li><input type="text" v-model="Rolename"></li>
                    <li><input type="text" v-model="telephone"></li>
                    <li class="btn_B" style="width: 101px;"><button class="btn_submit">保存</button></li>
            </ul>
          
        </div>
    </div>
</template>
<script>
    export default({
        data(){
            return{
                name:"XX设备",
                type:"",
                model:"",
                address:"",
                Rolename:"",
                telephone:""
            }
        },
        methods:{
            back(){
                this.$router.go(-1);//返回上一层
            },
        }
    })
</script>
<style scoped>
    .flex_top{width: 80%;margin: 0 auto;color: #fff}
    .flex_top ul{display: flex;justify-content: flex-start;}
    .flex_top ul:nth-child(1){width: 93%}
    .flex_top ul li{width: 25%;border: 1px solid #ccc;text-align: center;line-height: 30px;}
    .text_S{color: black}
    .flex_top ul li>input{border: none;width: 100%;text-align: center}
.btn_submit{background: none;cursor: pointer;}
</style>    