<template>
    <div id="presentation">
            <span @click="back" class="goback">返回</span>
            <div class="flex_box">
                    <div class="flex_left" ></div>
                    <div  class="flex_right">
                        <div class="flex_right_top">
                            <Button type="primary">打印报告</Button>
                            <div class="flex_right_top_C">
                                    <List item-layout="vertical">
                                            <ListItem v-for="item in Listdata" :key="item.title">
                                                <ListItemMeta :title="item.title" :description="item.description"/>
                                                {{item.content}}
                                            </ListItem>
                                        </List>
                            </div>
                        </div>
                        <div class="flex_right_bottom">
                            <textarea name="" id="" cols="30" rows="10" placeholder="请输入评价信息"></textarea>
                            <div><Button type="primary">录入评价</Button></div>   
                        </div>
                    </div>
            </div>
       
    </div>
</template>
<script>
    export default{
        data(){
            return{
                Listdata:[
                    {
                        title:"评价1",
                        description:"2019.11.11",
                        avatar:"111",
                        content:"This is the content, this is the content, this is the content, this is the content.",
                    },
                    {
                        title:"评价2",
                        description:"2019.11.11",
                        avatar:"111111",
                        content:"This is the content, this is the content, this is the content, this is the content.",
                    }
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
    .flex_box>div{
        overflow: hidden;
    }
    .flex_box .flex_left{
        width: 300px;
        height: 300px;
        border: 1px solid #fff;
        background: #fff;
        float: left;
    }
    .flex_box .flex_right{
        float: right
    }
    .flex_box .flex_right .flex_right_top  .flex_right_top_C{
        width: 400px;
        height: 200px;
        border: 1px solid #fff;
        background: #fff;
        overflow-y: scroll
    }
    .flex_right_bottom>textarea{
        width: 400px;
        height: 200px;
        border: 1px solid #fff;
        background: #fff;
        margin-top: 20px;
        font-size: 18px;
    }
</style>