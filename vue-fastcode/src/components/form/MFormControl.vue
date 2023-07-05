<template>
  <div class="m-form-control">
    <MFormLabel v-if="label" :required="required">{{ label }}</MFormLabel>
    <slot></slot>
    <MFormError v-if="error" :error="error"></MFormError>
  </div>
</template>

<script>
import MFormLabel from './MFormLabel.vue'
import MFormError from './MFormError.vue'
export default {
  name: 'MFormControl',
  props: {
    label: {
      type: String, // Tiêu đề nhập liệu
      required: false // Có thể false nếu dùng MFormLabel thay thế
    },
    required: {
      type: Boolean, // Nhập liệu có bắt buộc
      required: false
    },
    error: {
      type: String, // Tin nhắn lỗi
      required: false
    }
  },
  components: { MFormLabel, MFormError }
}
</script>