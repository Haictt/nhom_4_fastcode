<template>
  <div class="toast-message success">
    <span class="toast-icon">
      <i class="fas fa-check-circle"></i>
    </span>
    <span class="toast-title">Thành công!</span>
    <span class="toast-content">Công việc đã bị xóa.</span>
    <span class="toast-action">Hoàn tác</span>
    <span class="toast-close">
      <i class="fas fa-times"></i>
    </span>
  </div>
</template>

<script>
export default {
  name: 'MToastMessage',
  props: {
    variant: String,    // Kiểu toast message: ['info', 'warning', 'error', 'success']
    title: String,      // Tiêu đề message
    content: String,    // Nội dung tin nhắn
  }
}
</script>