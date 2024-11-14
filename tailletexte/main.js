const Mini = 8;
const Maxi = 48
const Def = 16

const app = {
    data() {
      return {
        taille: Def
      }
    },
    computed: {
        realTextSize() {
            if (this.taille < Mini || this.taille > Maxi) {
                this.taille=Def
            }
            return this.taille
        }
    },
    methods: {
        agrandir() {
            this.taille= this.taille<Maxi ? this.taille + 2 : Def
            
        },
        diminuer() {
            this.taille=this.taille>Mini ? this.taille -2 : Def
        }
    }
}
  
Vue.createApp(app).mount('#app')

