<template>
        <div id='ensemble '>
        <div id="crumbs" style="width: 100%;height: 40px;line-height: 40ppx;padding:5px 20px">
            <ul>
                <li><a href="#">当前页 <Icon type="ios-home-outline"></Icon></a></li>
                <li><a href="#">运行评估</a></li>
                <li><a href="#">集中展示</a></li>
            </ul>
        </div>
           <div class="flex_box">
                   <div class="flexBox"  v-for="site in Arrlist" @click="xitong(site.Sn)">
                                <h3>{{site.Pname}}</h3>
                                <div class="top_H">
                                        <div class="top_H_img">
                                            <img src="../../image/sun-on.gif" alt="">
                                        </div>
                                        <ul>
                                                <li><h3>综合指数：{{site.EvalValue}}</h3></li>
                                                <li>地址：{{site.Paddress}}</li>
                                        </ul>
                                </div>
                   </div>
           </div>
        </div>
</template>
<script>
        export default{
                data () {
                        return {
                                classObject: {
                                        class1: true 
                                },
                                Arrlist:[]
                        }
                },
                mounted(){
                        this.getArrlist();
                },
                methods:{
                        xitong(Sn){
                                this.$router.push({path:'/Systemevaluation',query:{sn:Sn}})
                               
                        },
                        getArrlist(){
                                this.$axios.get(this.$api+'Station/GetAllStaInfoAndEval').then((data) =>  {
                                        this.Arrlist = data.data
                                })
                        }

                },
        }
</script>
<style scoped>
        .flex_box{
                display: flex;
            display: -webkit-flex;
            flex-wrap: wrap;
        }
        .flex_box .flexBox {
                color:#fff;
                width: 24%;
                height:150px;
                border: 1px solid #ddd;
                margin: 10px 5px;
                padding: 5px;
                box-sizing: border-box;
                box-shadow: 0px 1px 3px rgba(34, 25, 25, 0.8);
                border-radius: 5px;
                cursor: pointer;
        }
        .flex_box .flexBox>h3{line-height: 40px;padding-left: 10px;}
        .top_H_img>img{
                display: block;width: 50px
        }
        .top_H{
                display: flex;
                justify-content: flex-start;
        }
        .top_H>ul{width: 80%;padding-left: 10px;}
        .top_H>ul>li{line-height: 40px;}
        .top_H_img{
                position:relative;height:50px;width:50px;
        }
</style>