<template>
  <MPopup :open="open" title="Thông tin chủ đề" @close="$emit('close')">
    <MFormControl label="Họ và tên" :required="true" :error="error.UserName">
      <MTextField ref="first-input" v-model="form.UserName" placeholder="Nhập họ và tên" :error="error.UserName"
        @blur="validate" />
    </MFormControl>
    <MFormControl label="Tiêu đề" :required="true" :error="error.TopicTitle">
      <MTextField v-model="form.TopicTitle" placeholder="Nhập tiêu đề" :error="error.TopicTitle" @blur="validate" />
    </MFormControl>
    <MFormControl label="Loại chủ đề" :required="true" :error="error.TopicType">
      <div class="flex--row">
        <span class="flex-1 text-align--left">
          <input type="radio" :value="$_MISAEnum.TOPICTYPE.Question" v-model="form.TopicType">
          Hỏi đáp
        </span>
        <span class="flex-1 text-align--left">
          <input type="radio" :value="$_MISAEnum.TOPICTYPE.Discussion" v-model="form.TopicType">
          Thảo luận
        </span>
        <span class="flex-1 text-align--left">
          <input type="radio" :value="$_MISAEnum.TOPICTYPE.Share" v-model="form.TopicType">
          Chia sẻ
        </span>
      </div>
    </MFormControl>
    <MFormControl :error="error.TopicContent">
      <MTextarea v-model="form.TopicContent" placeholder="Nhập nội dung" :error="error.TopicContent" />
    </MFormControl>
    <template v-slot:actions>
      <MButton variant="secondary" text="Hủy" color="secondary" @click="$emit('close')"></MButton>
      <MButton variant="primary" text="Lưu" @click="save"></MButton>
    </template>
  </MPopup>
</template>

<script>
import axios from 'axios';
export default {
  name: 'TopicCreateForm',
  props: {
    open: Boolean, // Trạng thái có mở form không?
  },
  emits: ['close'],
  data() {
    return {
      form: {
        UserName: '',
        TopicTitle: '',
        TopicType: 1,
        TopicContent: ''
      },
      error: {
        UserName: '',
        TopicTitle: '',
        TopicType: '',
        TopicContent: ''
      }
    }
  },
  methods: {
    /**
     * Kiểm tra dữ liệu
     * Author: PCTHANH (05/07/2023)
     */
    validate() {
      if (!this.form.UserName)
        this.error.UserName = 'Thông tin này không được để trống.'
      else this.error.UserName = ''

      if (!this.form.TopicTitle)
        this.error.TopicTitle = 'Thông tin này không được để trống.'
      else this.error.TopicTitle = ''

      if (this.form.TopicContent)
        this.error.TopicContent = 'Thông tin này không được để trống..'
      else this.error.TopicContent = ''
    },
    save() {
      console.log(this.form)
      axios.post('', this.form)
        .then(res => res.status === 201 ? this.$emit('close') : console.log(res.data))
        .catch(e => console.log(e))
    }
  },
  watch: {
    form: {
      deep: true,
      handler: function () {
        this.validate()
      }
    },
    open(newValue) {
      const input = this.$refs['first-input']
      if (newValue && input) input.focus();
      console.log(newValue)
    }
  }
}
</script>