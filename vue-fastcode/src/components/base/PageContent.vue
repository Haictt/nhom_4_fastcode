<template>
  <MTToolbar float="right" :actions="countChecked > 0">
    <template v-slot:left>
      <MTextField
        placeholder=""
        right-icon="m-icon search"
      />
    </template>
    <template v-slot:right>
      <MButton
        left-icon="m-icon add-white"
        text="Thêm danh hiệu"
        color="primary"
        @click="formOpen = true"
      ></MButton>
    </template>
    <template v-slot:actions>
      <span>
        Đã chọn
        <b>{{ countChecked >= 10 ? countChecked : "0" + countChecked }}</b>
      </span>
      <MButton
        variant="link"
        text="Bỏ chọn"
        color="primary"
        @click="emulationsList.forEach((item) => (item['IsChecked'] = false))"
      ></MButton>
      <MButton variant="outline" text="Sử dụng" color="primary"></MButton>
      <MButton
        variant="secondary"
        text="Ngừng sử dụng"
        color="secondary"
      ></MButton>
      <MButton variant="outline" text="Xóa" color="error"></MButton>
    </template>
  </MTToolbar>
</template>

<script>
export default {
  components: {
  },
};
</script>

<style scoped>
.page-content {
  background-color: #808080;
  width: 100%;
}
</style>
