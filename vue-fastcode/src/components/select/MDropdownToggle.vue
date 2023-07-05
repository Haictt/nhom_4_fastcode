<template>
  <div v-show="open" class="m-dropdown-toggle" ref="m-dropdown-toggle">
    <slot></slot>
  </div>
</template>

<script>
export default {
  name: 'MDropdownToggle',
  /**
   * Xử lý hiển thị nội dung của <slot></slot> để không bị tràn ra khỏi view
   * open: Trạng thái hiển thị (v-show)
   * top, bottom, left, right: vị trí hiển thị, giá trị tương ứng với top, bottom, left, right của css
   * Chú ý: Nếu top, left gây tràn ra khỏi view thì top, left = auto
   */
  props: ['open', 'top', 'bottom', 'left', 'right'],
  data() {
    return {
      topValue: this.top || 'auto',
      bottomValue: this.bottom || 'auto',
      leftValue: this.left || 'auto',
      rightValue: this.right || 'auto'
    }
  },
  /**
   * Tính toán lại vị trí hiển thị xem có bị tràn khỏi view không
   * Author: PCTHANH (03/07/2023)
   */
  updated() {
    const dropdown = this.$refs['m-dropdown-toggle']
    if (!dropdown) return
    const rect = dropdown.getBoundingClientRect()
    let viewWidth = window.innerWidth
    let viewHeight = window.innerHeight

    if (this.top && this.bottom) {
      if (rect.bottom > viewHeight) this.topValue = 'auto'
    }
    if (this.left && this.right) {
      if (rect.right > viewWidth) this.leftValue = 'auto'
    }
  }
}
</script>

<style scoped>
.m-dropdown-toggle {
  top: v-bind('topValue');
  bottom: v-bind('bottomValue');
  left: v-bind('leftValue');
  right: v-bind('rightValue');
}
</style>