<template>
  <div class="m-combobox" tabindex="-1">
    <input type="text" ref="m-combobox-input" class="m-combobox-input" :placeholder="placeholder" v-model="inputValue"
      @keydown="onKeyDown" @input="search" />
    <span class="m-combobox-icon" @click="openDropdown">
      <span class="m-icon combo--dropdown"></span>
    </span>
    <MDropdownToggle :open="dropdownOpen" top="calc(100% + 1px)" bottom="calc(100% + 1px)">
      <MSelectList :modelValue="modelValue" @update:modelValue="onSelect($event)" :list="selectList"
        :focusedIndex="focusedIndex">
      </MSelectList>
    </MDropdownToggle>
  </div>
</template>

<script>
import MSelectList from '../select/MSelectList.vue'
import MDropdownToggle from '../select/MDropdownToggle.vue'
export default {
  name: 'MCombobox',
  components: { MSelectList, MDropdownToggle },
  props: {
    modelValue: [String, Number], // Giá trị của combobox
    list: Array, // Danh sách options: Array<String|Number|{label, value}>
    placeholder: {
      // Văn bản thay thế
      type: String,
      required: false
    },
    color: {
      // Màu của combobox
      type: String, // Kiểu: ['primary', 'secondary', 'info', 'success', 'warning', 'error', string]
      required: false // Mặc định: primary
    },
    error: {
      // Trạng thái error tạo border red cho combobox
      type: Boolean,
      required: false // Mặc định: không error
    },
    tabIndex: {
      type: Number,
      required: false // Mặc định: -1
    }
  },
  emits: ['update:modelValue', 'blur', 'input'],
  data() {
    return {
      inputValue: '',
      dropdownOpen: false,
      focusedIndex: 0,
      formatList: [],
      selectList: []
    }
  },
  computed: {
    /**
     * Chuyển đổi màu cho combobox: chuyền từ color sang css var
     * Author: PCTHANH (26/06/2023)
     * @returns String là css variable
     */
    comboboxColor() {
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
     * Xử lý sự kiện khi click vào 1 item trong dropdown
     * Author: PCTHANH (27/06/2023)
     * @param {*} value Giá trị của item
     */
    onSelect(value) {
      this.inputValue = this.formatList.find((i) => i.value === value).label
      this.focus()
      this.$emit('update:modelValue', value)
      this.dropdownOpen = false
    },
    /**
     * Xử lý sự kiện khi click vào icon để mở dropdown
     * Author: PCTHANH (29/06/2023)
     */
    openDropdown() {
      this.focus()
      this.selectList = this.formatList
      this.focusedIndex = this.selectList.findIndex((item) => item.value === this.modelValue)
      this.dropdownOpen = true
    },
    /**
     * Thực hiện seach khi input thay đổi
     * Author: PCTHANH (04/07/2023)
     * @param {Event} event Sự kiện input
     */
    search(event) {
      const value = event.target.value;
      this.focusedIndex = 0
      this.$emit('input', value)
      this.selectList = this.formatList.filter((item) =>
        item.label.toString().toUpperCase().includes(value.toUpperCase())
      )
    },
    /**
     * Xử lý sự kiện nhấn phím của combobox
     * (Hỗ trợ sử dụng combobox không cần chuột)
     * Author: PCTHANH (03/07/2023)
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
          this.dropdownOpen = true
          return
      }
    },
    /**
     * Hàm hỗ trợ focus
     * Author: PCTHANH (03/07/2023)
     */
    focus() {
      this.$refs['m-combobox-input'].focus()
    }
  },
  /**
   * Format list và đặt input mặc định theo modelValue
   * Author: PCTHANH (04/07/2023)
   */
  created() {
    if (!this.list || !this.list.length) return
    this.formatList = this.list.map((item) => ({
      label: item.label !== undefined ? item.label : item,
      value: item.value !== undefined ? item.value : item
    }))
    console.log(this.formatList)
    this.inputValue = this.formatList.find((i) => i.value === this.modelValue)?.label || ''
  },
  watch: {
    /**
     * Thay đổi input theo modelValue
     * Author: PCTHANH (04/07/2023)
     * @param {*} newValue Giá trị modelValue mới
     */
    modelValue(newValue) {
      this.inputValue = this.formatList.find((i) => i.value === newValue)?.label || ''
    },
    /**
     * Thay đổi formatList theo list
     * Author: PCTHANH (04/07/2023)
     * @param {*} newValue Giá trị mới của list
     */
    list(newValue) {
      if (!newValue || !newValue.length) return
      this.formatList = newValue.map((item) => ({
        label: item.label !== undefined ? item.label : item,
        value: item.value !== undefined ? item.value : item
      }))
    }
  }
}
</script>

<style scoped>
.m-combobox {
  --combobox-color: v-bind('comboboxColor');
}
</style>
