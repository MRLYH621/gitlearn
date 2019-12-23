<template>
    <div class='updatePwdBox'>
     <span @click="back" class="goback">返回</span>
        <div class='updatePwdBox-cell'>
            <div  class="updatePwdBox-cell-title"><i  class="updatePwdBox-cell-title-i">修改密码</i></div>
            <div class='updatePwdBoxFormBox'>
            <div class='updatePwdBoxForm'>
                <div>设置新密码</div>
                <div><input type="text" style="color: #000"></div>
            </div>
            <div class='updatePwdBoxForm'>
                <div>再次输入密码</div>
                <div><input type="text" style="color: #000"></div>
            </div>
            <div class='updatePwdBoxForm-btnBox'>
                <button type="button" class="button-white" style="padding: 0px 10px;">保存</button>
                <button type="button" class="button-white" style="padding: 0px 10px;">重置</button>
            </div>
            </div>
        </div>
    </div>
</template>
<script>
    export default{
        data(){
            return{
               
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
.updatePwdBox{
    width: 100%;
    height: 600px;
    padding: 5px;

}
/* .updatePwdBox-cell{
    width: 100%;
    height:100%;
    -webkit-box-shadow: inset 2px 2px 1px RGB(30,30,30), 2px 2px 1px RGB(30,30,30);
    box-shadow: inset 2px 2px 1px RGB(30,30,30), 2px 2px 1px RGB(30,30,30);
    border-radius: 6px;
    background-color: RGB(43,50,58);
    padding: 5px;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
} */
.updatePwdBox-cell-title{
    width: 100%;
    height: 30px;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
}
.updatePwdBox-cell-title-i{
    height: 30px;
    line-height: 30px;
    float: left;
    color: white;
    font-weight: 700;
}
.updatePwdBoxFormBox{
    border:1px solid white;
    
    width:350px;
    margin: 0 auto;
    margin-top: 100px;
    padding:10px

}
.updatePwdBoxForm{
    width: 300px;
    height: 30px;
    /* background-color: pink; */
    margin: 10px auto;
    display: flex;
    justify-content:flex-start;

}
.updatePwdBoxForm>div{
   
    line-height: 30px;
    height: 30px;
    justify-content: center;

}
.updatePwdBoxForm>div:nth-child(1){
     width: 40%;
    color: white
}
.updatePwdBoxForm>div:nth-child(2){
     width: 60%;
   
}
.updatePwdBoxForm>div:nth-child(2) input{
    width: 100%;
    height: 100%;
}
.updatePwdBoxForm-btnBox{
    width: 300px;
    height: 30px;
    /* background-color: pink; */
    margin: 30px auto;
    display: flex;
    justify-content:space-around;
}
 .goback{
        border-top-right-radius: 10px;
        border-bottom-right-radius: 10px;
        width: 100px;
        height: 30px;
        line-height: 30px;
        padding: 0px 20px 0 20px;
        text-align: center;
        background-color: #000;
        color: #fff;
        text-decoration: none; 
        text-align: center;
        font-size: 14px;
        position: relative;
        display: block;
        float: right;
        cursor: pointer;
    }
    .goback:before{
            display: none;
     }
     .goback:after{
        content: "";
        border-right: 20px solid #000;
    border-top: 15px solid transparent;
    border-bottom: 15px solid transparent;
        position: absolute;
        left: -20px;
        top: 0;
     }
</style>
