<template>
  <div :class="['m-select', error && 'error']" :tabindex="tabIndex || -1" ref="m-select" @keydown="onKeyDown"
    @blur="$emit('blur')">
    <input type="text" class="m-select-input" :placeholder="placeholder" :value="modelValue" readonly
      @click="openDropdown" />
    <span class="m-select-icon" @click="openDropdown">
      <span class="m-icon combo--dropdown"></span>
    </span>
    <MDropdownToggle :open="dropdownOpen" top="calc(100% + 1px)" bottom="calc(100% + 1px)">
      <MSelectList :modelValue="modelValue" @update:modelValue="onSelect($event)" :list="list"
        :focusedIndex="focusedIndex" />
    </MDropdownToggle>
  </div>
</template>

<script>
import MSelectList from './MSelectList.vue'
import MDropdownToggle from './MDropdownToggle.vue'
export default {
  name: 'MSelect',
  components: { MSelectList, MDropdownToggle },
  props: {
    modelValue: [String, Number], // Giá trị của select
    list: Array, // Danh sách options
    placeholder: {
      // Văn bản thay thế
      type: String,
      required: false
    },
    color: {
      // Màu của select
      type: String, // Kiểu: ['primary', 'secondary', 'info', 'success', 'warning', 'error', string]
      required: false // Mặc định: primary
    },
    error: {
      // Trạng thái error tạo border red cho select
      type: Boolean,
      required: false // Mặc định: không error
    },
    tabIndex: {
      type: Number,
      required: false // Mặc định: -1
    }
  },
  emits: ['update:modelValue', 'blur'],
  data() {
    return {
      dropdownOpen: false,
      focusedIndex: 0
    }
  },
  computed: {
    /**
     * Chuyển đổi màu cho select: chuyền từ color sang css var
     * Author: PCTHANH (26/06/2023)
     * @returns String là css variable
     */
    selectColor() {
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
     * Xử lý sự kiện khi mở dropdown
     * Author: PCTHANH (30/06/2023)
     */
    openDropdown() {
      this.focus()
      this.dropdownOpen = true
      if (this.list && this.list.length) {
        this.focusedIndex = this.list.findIndex((item) => (item.value || item) === this.modelValue)
      }
    },
    /**
     * Xử lý sự kiện khi click vào 1 item trong select list
     * Author: PCTHANH (27/06/2023)
     * @param {*} value Giá trị của item
     */
    onSelect(value) {
      this.focus()
      this.$emit('update:modelValue', value)
      this.dropdownOpen = false
    },
    /**
     * Xử lý sự kiện nhấn phím của select-list
     * (Hỗ trợ sử dụng select-list không cần chuột)
     * Author: PCTHANH (28/06/2023)
     * @param {Event} event event của dom
     */
    onKeyDown(event) {
      switch (event.key) {
        case 'ArrowUp':
          if (this.focusedIndex > 0) this.focusedIndex = this.focusedIndex - 1
          break
        case 'ArrowDown':
          if (this.focusedIndex < this.list.length - 1) this.focusedIndex = this.focusedIndex + 1
          break
        case 'Enter':
          if (this.dropdownOpen) {
            const value = this.list[this.focusedIndex].value || this.list[this.focusedIndex]
            this.onSelect(value)
          } else this.openDropdown()
          break
        default:
          return
      }
    },
    /**
     * Hàm hỗ trợ focus
     * Author: PCTHANH (01/07/2023)
     */
    focus() {
      this.$refs['m-select'].focus()
    }
  }
}
</script>

<style scoped>
.m-select {
  --select-color: v-bind('selectColor');
}
</style>