<template>
  <div class="m-toast-container">
    <MToastMessage variant="success" title="Thành công!" content="Danh mục thi đua đã được thêm."></MToastMessage>
  </div>
</template>

<script>
import MToastMessage from './MToastMessage.vue'
export default {
  name: 'MToastContainer',
  components: { MToastMessage }
}
</script>