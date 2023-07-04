<template>
  <div class="m-textfield">
    <span v-if="leftIcon" class="left-icon">
      <div :class="leftIcon"></div>
    </span>
    <MInput ref="m-input" :modelValue="modelValue" @update:modelValue="$emit('update:modelValue', $event)"
      :placeholder="placeholder" :readOnly="readOnly" :error="error" :color="color" @blur="$emit('blur')"
      :tabIndex="tabIndex" />
    <span v-if="rightIcon" :class="['right-icon', isAction !== undefined && 'action']">
      <div :class="rightIcon"></div>
    </span>
  </div>
</template>

<script>
import MInput from './MInput.vue'
export default {
  name: 'MTextField',
  components: { MInput },
  props: [
    'modelValue', // Giá trị của input
    'leftIcon', // ClassName cho thẻ div của icon bên trái input
    'rightIcon', // ClassName cho thẻ div của icon bên phải input
    'isAction', // Icon bên phải có phải action không?
    'error', // Trạng thái error tạo boder red cho input
    'placeholder', // Văn bản thay thế
    'readOnly', // Text-field chỉ đọc
    'color', // Màu của m-input: ['primary', 'secondary', 'info', 'success', 'warning', 'error', string]
    'tabIndex'
  ],
  emits: ['update:modelValue', 'blur'],
  methods: {
    /**
     * Hỗ trợ focus input
     * Author: PCTHANH (03/07/2023)
     */
    focus() {
      this.$refs['m-input'].focus()
    }
  }
}
</script>