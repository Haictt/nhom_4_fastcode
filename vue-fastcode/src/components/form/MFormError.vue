<template>
  <div v-show="error" class="m-form-error-text">
    <slot>
      {{ error }}
    </slot>
  </div>
</template>

<script>
export default {
  name: 'MFormError',
  props: {
    error: {
      type: [String, Boolean], // Tin nhắn lỗi
      required: false // Nếu error là Boolean thì sử dụng slot thay cho tin nhắn lỗi
    }
  }
}
</script>