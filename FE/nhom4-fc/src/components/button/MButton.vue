<template>
  <button :class="['m-button', btnVariant, size]" @click="$emit('click')" :tabindex="tabIndex || -1"
    @keydown.enter="$emit('click')">
    <span v-if="leftIcon" class="left-icon">
      <div :class="leftIcon"></div>
    </span>
    <span v-if="text" class="btn-text">{{ text }}</span>
    <span v-if="icon" class="icon">
      <div :class="icon"></div>
    </span>
    <span v-if="dropdown" class="dropdown-toggle">
      <div></div>
    </span>
  </button>
</template>

<script>
export default {
  name: 'MButton',
  props: {
    size: {
      // Kích cỡ của button
      type: String, // Kiểu: ['small', 'medium', 'large']
      required: false // Mặc định: medium
    },
    variant: {
      // Kiểu button
      String, // Kiểu: ['primary', 'secondary', 'ouline', 'link', 'icon']
      required: false // Mặc định: primary
    },
    color: {
      // Màu của button
      type: String, // kiểu: ['primary', 'secondary', 'info', 'success', 'warning', 'error', string]
      required: false // Mặc định: primary
    },
    leftIcon: {
      // ClassName cho thẻ div hiển thị left-icon bên trái text
      type: String,
      required: false
    },
    icon: {
      // ClassName cho thẻ div: Icon chính được hiển thị trong button
      type: String,
      required: false
    },
    text: {
      // Văn bản chính hiển thị trong button
      type: String,
      required: false
    },
    dropdown: {
      // Icon dropdown bên phải text
      type: Boolean,
      required: false
    },
    tabIndex: {
      type: Number,
      required: false // Mặc định: -1
    }
  },
  emits: ['click'],
  computed: {
    /**
     * Ánh xạ màu cho button: chuyền từ color sang css var
     * Author: PCTHANH (26/06/2023)
     * @returns String là css variable
     */
    btnColor() {
      switch (this.color) {
        case 'primary':
          return 'var(--primary-color)'
        case 'secondary':
          return 'var(--secondary-color)'
        case 'info':
          return 'var(--info-color)'
        case 'success':
          return 'var(--success-color)'
        case 'warning':
          return 'var(--warning-color)'
        case 'error':
          return 'var(--error-color)'
        default:
          return this.color || 'var(--primary-color)'
      }
    },
    /**
     * Ánh xạ loại button từ variant
     * Author: PCTHANH (26/06/2023)
     * @returns String là class name của button
     */
    btnVariant() {
      switch (this.variant) {
        case 'primary':
          return 'm-btn-primary'
        case 'secondary':
          return 'm-btn-secondary'
        case 'outline':
          return 'm-btn-outline'
        case 'link':
          return 'm-btn-link'
        case 'icon':
          return 'm-btn-icon'
        default:
          return 'm-btn-primary'
      }
    }
  }
}
</script>

<style scoped>
.m-button {
  --btn-color: v-bind('btnColor');
}
</style>
