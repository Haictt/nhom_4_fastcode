<template>
  <MTToolbar float="right" :actions="countChecked > 0">
    <template v-slot:left>
      <h1>Thảo luận/ Hỏi đáp</h1>
    </template>
    <template v-slot:right>
      <MButton
        left-icon="m-icon add-white"
        text="Thêm thảo luận/ Câu hỏi"
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
  data() {
    return {
      formOpen: false,
    };
  },
};
</script>
