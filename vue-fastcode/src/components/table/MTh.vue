<template>
  <th :class="['m-th', align]" ref="m-th">
    <slot></slot>
    <div v-if="resizable" class="m-th-resize" @mousedown="onMouseDown"></div>
  </th>
</template>
  
<script>
export default {
  name: 'MTh',
  props: {
    textAlign: String, // Căn chỉnh cột
    width: {
      // Độ rộng cột
      type: String, // Giá trị css. Ví dụ: '200px'
      required: false // Mặc định: auto
    },
    resizable: {
      // Cho chép resize động rộng cột
      type: Boolean,
      required: false // Mặc định false
    }
  },
  data() {
    return {
      w: this.width || 'auto'
    }
  },
  computed: {
    /**
     * Ánh xạ props tới class để Căn chỉnh cột
     * @returns Tên class tương ứng
     */
    align() {
      switch (this.textAlign) {
        case 'name':
        case 'text':
        case 'gender':
        case 'left':
          return 'text-align--left'
        case 'number-phone':
        case 'number':
        case 'right':
          return 'text-align--right'
        case 'date':
        case 'center':
          return 'text-align-center'
        default:
          return this.textAlign
      }
    }
  },
  methods: {
    /**
     * Bắt đầu xử lý khi click vào div đê resize
     * Author: PCTHANH (30/06/2023)
     */
    onMouseDown() {
      window.addEventListener('mousemove', this.resize)
      window.addEventListener('mouseup', () => window.removeEventListener('mousemove', this.resize))
    },
    /**
     * Xử lý sự kiện con chuột di chuyển và cập nhật th.style.width
     * Author: PCTHANH (30/06/2023)
     * @param {*} event Đối tượng sự kiện
     */
    resize(event) {
      const currentX = event.x
      const x = this.$refs['m-th'].getBoundingClientRect().left
      this.w = currentX - x + 'px'
    }
  }
}
</script>

<style scoped>
.m-th {
  width: v-bind('w');
  min-width: v-bind('w');
  max-width: v-bind('w');
}
</style>
