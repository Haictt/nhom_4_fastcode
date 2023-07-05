<template>
  <input ref="m-input" :class="['m-input', error && 'error']" type="text" :placeholder="placeholder" :readonly="readOnly"
    :value="modelValue" @input="$emit('update:modelValue', $event.target.value)" @blur="$emit('blur')"
    :tabindex="tabIndex" />
</template>

<script>
export default {
  name: 'MInput',
  props: ['modelValue', 'placeholder', 'readOnly', 'error', 'color', 'tabIndex'],
  emits: ['update:modelValue', 'blur'],
  computed: {
    /**
     * Ánh xạ màu cho input: chuyền từ color sang css var
     * Author: PCTHANH (26/06/2023)
     * @returns String là css variable
     */
    inputColor() {
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
    }
  },
  methods: {
    /**
     * Hỗ trợ focus input
     * Author: PCTHANH (01/07/2023)
     */
    focus() {
      this.$refs['m-input'].focus()
    }
  }
}
</script>

<style scoped>
.m-input {
  /* Màu cơ bản của input text*/
  --input-color: v-bind('inputColor');
}
</style>