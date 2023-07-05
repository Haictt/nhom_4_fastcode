<template>
  <div class="m-textarea">
    <textarea ref="m-textarea" :placeholder="placeholder" :value="modelValue"
      @input="$emit('update:modelValue', $event.target.value)" @blur="$emit('blur')"
      :tabindex="tabIndex || -1"></textarea>
  </div>
</template>

<script>
export default {
  name: 'MTextarea',
  props: {
    modelValue: {
      // Giá trị textarea
      type: String,
      required: false
    },
    placeholder: {
      // Văn bản thay thế
      type: String,
      required: false
    },
    tabIndex: {
      type: Number,
      required: false // Mặc định: -1
    }
  },
  emits: ['update:modelValue', 'blur'],
  methods: {
    /**
     * Hỗ trợ focus textarea
     * Author: PCTHANH (03/07/2023)
     */
    focus() {
      this.$refs['m-textarea'].focus()
    }
  }
}
</script>