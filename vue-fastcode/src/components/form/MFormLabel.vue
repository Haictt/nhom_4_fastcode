<template>
  <label :for="forId" class="m-form-label">
    <slot></slot>
    <span v-show="required" class="required">*</span>
  </label>
</template>

<script>
export default {
  name: 'MFormLabel',
  props: {
    required: {
      // Trường nhập liệu có bắt buộc không
      type: Boolean,
      required: false // Mặc định: false
    },
    forId: {
      type: String, // Id focus của thẻ label
      required: false
    }
  }
}
</script>