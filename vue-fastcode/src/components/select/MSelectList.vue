<template>
  <div class="m-select-list">
    <div v-for="(item, index) in formatList" :key="item.value" :class="itemClass(index, item)"
      @click="$emit('update:modelValue', item.value)">
      {{ item.label }}
    </div>
  </div>
</template>

<script>
export default {
  name: 'MSelectList',
  props: {
    modelValue: [String, Number], // Giá trị của select
    list: Array, // Danh sách options
    displayNumber: {
      type: Number, // Số lượng option được hiển thị
      required: false // Mặc định tối đa hiển thị 20 options
    },
    focusedIndex: {
      type: Number, // Chỉ mục index của option được focus
      required: false // Mặc định focus option có giá trị modelValue
    }
  },
  emits: ['update:modelValue'],
  computed: {
    /**
     * Định dạng danh sách đầu vào
     * Author: PCTHANH (28/06/2023)
     * @returns Array<{label, value}> Mảng đã được định dạng
     */
    formatList() {
      if (!this.list || !this.list.length) return []
      return this.list.map((item) => ({
        label: item.label !== undefined ? item.label : item,
        value: item.value !== undefined ? item.value : item
      }))
    },
    /**
     * Tính số lượng item tối đa hiển thị
     * Author: PCTHANH (30/06/2023)
     * @returns Number Số lượng phần tử hiển thị
     */
    maxElementDisplay() {
      try {
        if (this.displayNumber && !isNaN(Number(this.displayNumber)))
          return Number(this.displayNumber)
        return 20
      } catch (e) {
        console.log(e)
        return 20
      }
    }
  },
  methods: {
    /**
     * Tính toán class name cho item theo giá trị modelValue và focusedIndex
     * @param {Number} index Chỉ mục của item
     * @param {*} item Giá trị mà item hiển thị
     */
    itemClass(index, item) {
      const cs = ['m-select-item']
      if (this.focusedIndex === undefined) {
        if (this.modelValue === item.value) cs.push(['selected', 'focused'])
      } else {
        if (this.modelValue === item.value) cs.push(['selected'])
        if (this.focusedIndex === index) cs.push(['focused'])
      }
      return cs
    }
  }
}
</script>

<style scoped>
.m-select-list {
  --number-of-elements: v-bind('maxElementDisplay');
}
</style>
