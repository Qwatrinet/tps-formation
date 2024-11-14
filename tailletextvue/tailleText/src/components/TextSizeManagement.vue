<script>
import IncreaseButton from '@/components/IncreaseButton.vue'
import InputSizeText from '@/components/InputSizeText.vue'
export default {
    data() {
        return {
            size: 16,
            max: 48,
            min: 8
        }
    },
    components: {
        IncreaseButton,
        InputSizeText
    },
    methods: {
        increment() {
            this.size += 1
            if (this.size > this.max) {
                this.size = 16
            }
        },
        setSize(s) {
            this.size = s
        }
    }
}
</script>

<template>
    <div :class="this.class">
        <IncreaseButton @click="increment" />
        <InputSizeText :min="min" :max="max" v-model:size="size">px</InputSizeText>
        <p>Taille Actuelle: {{ size }}px</p>
        <p :style="{ 'font-size': size + 'px' }">Lorem ipsum dolor sit amet consectetur adipisicing elit. Doloremque,
            voluptatem quisquam
            voluptate cum obcaecati nulla repudiandae commodi explicabo iure? Eaque sint necessitatibus ipsa eum
            cupiditate
            tenetur error nobis reprehenderit recusandae.</p>
    </div>
</template>

<style scoped></style>