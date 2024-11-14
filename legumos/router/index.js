import { createRouter, createWebHistory } from 'vue-router' 
import HomeMain from '/src/components/HomeMain.vue';
import VentesMain from '@/components/VentesMain.vue';
import NewVeggie from '@/components/NewVeggie.vue';

const routes = [    
    { path: '/bob',name:"bob", component: VentesMain},
    
    { path: '/', name: 'home', component: HomeMain },
    
    {path:'/NewVeggie',name:'NewVeggie',component: NewVeggie}
]
const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes
})


export default router;