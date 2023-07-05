<template>
  <div v-if="open" class="m-popup">
    <div class="m-popup-container">
      <div class="m-popup-btns">
        <slot name="btns">
          <div class="m-icon close" @click="$emit('close')"></div>
        </slot>
      </div>
      <div class="m-popup-header">{{ title }}</div>
      <div class="m-popup-main">
        <slot></slot>
      </div>
      <div class="m-popup-footer">
        <slot name="actions"></slot>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'MPopup',
  props: {
    open: Boolean, // Trạng thái hiển thị của popup
    title: String // Tiêu đề của popup
    /**
     * Bao gồm 3 slot
     * btns: Chứa các button góc trên bên phải, mặc định chứa icon button close
     * default: Nội dụng popup
     * actions: Các hành động nằm ở footer của popup
     */
  },
  emits: ['close'] // event handler close popup
}
</script>