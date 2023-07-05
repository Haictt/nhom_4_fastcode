<template>
  <div v-if="message.length > 0" class="m-toast-container">
    <MToastMessage v-for="item in message" :key="item.id" :variant="item.variant" :title="item.title"
      :content="item.content" @close="close(item.id)">
    </MToastMessage>
  </div>
</template>

<script>
import MToastMessage from './MToastMessage.vue'
export default {
  name: 'MToastContainer',
  components: { MToastMessage },
  data() {
    return {
      message: [],
      id: 1
    }
  },
  methods: {
    close(id) {
      const index = this.message.findIndex(i => i.id === id);
      if (index > -1) { // only splice array when item is found
        this.message.splice(index, 1); // 2nd parameter means remove one item only
      }
    }
  },
  mounted() {
    this.$_emitter.on('m-toast-container', (variant, title, content, action) => {
      this.message.push({
        variant, title, content, action, id: this.id++
      })
    })
  }
}
</script>