<template>
  <div v-if="open">
    <MFormControl>
      <MTextField ref="first-input" v-model="form.UserName" placeholder="Nhập họ và tên" :error="error.UserName"
        @blur="validate" />
    </MFormControl>
    <MFormControl>
      <MTextarea v-model="form.CommentContent" placeholder="Nhập nội dung" :error="error.CommentContent" />
    </MFormControl>
    <div>
      <MButton variant="primary" text="Hủy" color="error" @click="$emit('close')"></MButton>
      <MButton variant="primary" text="Trả lời" @click="save"></MButton>
    </div>
  </div>
</template>

<script>
export default {
  name: 'TopicCreateForm',
  props: {
    open: Boolean, // Trạng thái có mở form không?
    topic: Object   // Topic muốn trả lời
  },
  emits: ['close'],
  data() {
    return {
      form: {
        UserName: '',
        CommentContent: '',
      },
      error: {
        CommentContent: ''
      }
    }
  },
  methods: {
    validate() {
      if (!this.form.CommentContent)
        this.error.CommentContent = 'Thông tin này không được để trống.'
      else this.error.CommentContent = ''
    },
    save() {
      console.log(this.form)
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
      if (newValue) this.$refs['first-input'].focus();
    }
  }
}
</script>
