<template>
  <div :class="['m-toast-message', variant]">
    <span class="toast-icon">
      <i class="fas fa-check-circle"></i>
    </span>
    <span class="toast-title">{{ title }}</span>
    <span class="toast-content">{{ content }}</span>
    <!-- <span class="toast-action">Hoàn tác</span> -->
    <span class="toast-close" @click="$emit('click')"></span>
  </div>
</template>

<script>
export default {
  name: 'MToastMessage',
  props: {
    variant: String,    // Kiểu toast message: ['info', 'warning', 'error', 'success']
    title: String,      // Tiêu đề message
    content: String,    // Nội dung tin nhắn
    action: {
      type: { label: String, onClick: Function },
      require: false
    }
  },
  emits: ['close'],
  mounted() {
    setTimeout(() => { this.$emit('close') }, 5000);
  }
}
</script>