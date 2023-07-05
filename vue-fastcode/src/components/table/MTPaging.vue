<template>
  <div class="m-table-paging">
    <span class="record-total">
      Tổng số:<b>{{ total }}</b>bản ghi
    </span>
    <span class="m-table-actions">
      <span class="text">Số bản ghi/trang</span>
      <MSelect :list="sizeList" :modelValue="pageSize" @update:modelValue="changePageSize($event)"
        @blur="console.log('blur m-select')" />
      <span class="record-range">
        <b>{{ start }}</b>-<b>{{ end }}</b>bản ghi
      </span>
      <span class="paging-controls">
        <span class="prev-page-btn" @click="changePage(page - 1)">
          <span :class="['m-icon', 'move', 'prev', start <= 1 && 'disabled']"></span>
        </span>
        <span class="next-page-btn" @click="changePage(page + 1)">
          <span :class="['m-icon', 'move', 'next', end >= total && 'disabled']"></span>
        </span>
      </span>
    </span>
  </div>
</template>

<script>
export default {
  name: 'MTPaging',
  props: {
    total: Number, // Tổng số bản ghi
    page: Number, // Trang hiện tại
    pageSize: Number, // Số bản ghi trên 1 trang
    sizeList: Array // Danh sách pageSize
  },
  emits: ['update:page', 'update:pageSize'],
  computed: {
    /**
     * Tính chỉ mục bản ghi bắt đầu
     * Author: PCTHANH (03/07/2023)
     * @returns Chỉ mục bản ghi bắt đầu
     */
    start() {
      return (this.page - 1) * this.pageSize + 1
    },
    /**
     * Tính chỉ mục bản ghi kết thúc
     * Author: PCTHANH (03/07/2023)
     * @returns Chỉ mục bản ghi kết thúc
     */
    end() {
      return Math.min(this.page * this.pageSize, this.total)
    }
  },
  methods: {
    /**
     * Xử lý sự kiện chuyển trang
     * Author: PCTHANH (29/06/2023)
     * @param {Number} value Trang cần hiển thị
     */
    changePage(value) {
      if (value <= 0) return
      if ((value - 1) * this.pageSize > this.total) return
      this.$emit('update:page', value)
    },
    /**
     * Xử lý sự kiện thay đổi số lượng hiển thị
     * Author: PCTHANH (29/06/2023)
     * @param {Number} value Số lượng phần tử trong 1 trang
     */
    changePageSize(value) {
      this.$emit('update:pageSize', value)
      this.$emit('update:page', 1)
    }
  }
}
</script>