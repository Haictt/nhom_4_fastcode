<template>
  <div class="discuss-page">
    <div class="discuss-title">
      <span>Tiêu đề: </span>
      <span>{{ topic['TopicTitle'] }}</span>
    </div>
    <div class="topic-username">
      <span>Người đăng</span>
      <span>{{ topic['UserName'] }}</span>
    </div>
    <div class="topic-content">
      "{{ topic['TopicContent'] }}"
    </div>
    <div class="line"></div>
    <div class="topic-form">
      <ReplyForm :topic="topic" :open="replyFormOpen"></ReplyForm>
      <MButton variant="primary" text="Trả lời" color="primary" @click="replyFormOpen = true"></MButton>
    </div>
    <div class="comment-list">
      <div v-for="item in commentList" class="comment-item" :key="item['CommentId']">
        <div>
          <div class="comment-name">{{ item['UserName'] }}</div>
          <div class="comment-time">{{ item['CreateDate'] }}</div>
        </div>
        <div class="comment-content">{{ item['CommentContent'] }}</div>
      </div>
    </div>
  </div>
</template>

<script>
// import axios from 'axios';
import ReplyForm from '../form/ReplyForm.vue'
export default {
  name: 'DiscussDetail',
  components: { ReplyForm },
  props: ['topic'],
  data() {
    return {
      replyFormOpen: false,
      commentList: []
    }
  },
  mounted() {
    this.commentList = [];
    this.loadComment()
  },
  methods: {
    loadComment() {
      // const offset = this.commentList.length;
      // const limt = 10;
      // axios.get('', )
    }
  }
}
</script>

<style scoped></style>