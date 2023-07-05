<template>
  <div>
    <MisaToolbar></MisaToolbar>

    <div>
      <MTToolbar float="right">
        <template v-slot:left>
          <MTextField placeholder="" right-icon="m-icon search" />
        </template>
        <template v-slot:right>
          <MButton
            left-icon="m-icon  reload--icon"
            color="primary"
            variant="secondary"
            @click="formOpen = true"
          ></MButton>
        </template>
        <template v-slot:actions> </template>
      </MTToolbar>

      <div v-for="(question, index) in questions" :key="index">
        <div class="question-item">
          <div>
            <div class="question-icon" v-if="question.TopicType === $_MISAEnum.TOPICTYPE.Question"></div>
            <div class="share-icon" v-if="question.TopicType === $_MISAEnum.TOPICTYPE.Share"></div>
            <div class="comment-icon" v-if="question.TopicType === $_MISAEnum.TOPICTYPE.Discussion"></div>
          </div>
          <div class="question-detail-container">
            <div class="question-title" @click="!isShowDetails">
              {{ question.Username }}
            </div>
            <div class="question-replier">
              <div class="replier">
                {{ question.TopicTitle }}
              </div>
              <div class="number-of-question">
                Đã trả lời: {{ question.NumberOfQuestion }}
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import MisaToolbar from "./MisaToolbar.vue";
export default {
  components: {
    MisaToolbar,
  },
  mounted() {
    // fetch("http://10.0.135.39:8080/")
    // .then((res) => res.json())
    // .then((data) => {
    //   this.questions = data;
    // });
    this.questions = [
      {
        TopicId: 0,
        Username: "Hai",
        TopicType: 2,
        TopicTitle: "Jhin",
        TopicContent: null,
        NumberOfQuestion: 100,
      },
      {
        TopicId: 1,
        Username: "Lee Sinn",
        TopicType: 1,
        TopicTitle: "Cách để đẩy dữ liệu lên Git",
        TopicContent: null,
        NumberOfQuestion: 70,
      },
      {
        TopicId: 3,
        Username: "Vayne",
        TopicType: 3,
        TopicTitle: "Cách để thắng FastCode",
        TopicContent: null,
        NumberOfQuestion: 80,
      },
      {
        TopicId: 2,
        Username: "Yasuo",
        TopicType: 2,
        TopicTitle: "Cách để học hiệu quả ?",
        TopicContent: null,
        NumberOfQuestion: 60,
      },
    ];
  },
  data() {
    return {
      questions: [],
      isShowDetails: false,
    };
  },
};
</script>

<style scoped>
.question-item {
  display: flex;
  align-items: center;
  column-gap: 16px;
  height: 40px;
  padding: 30px 20px;
}

.question-detail-container {
  display: flex;
  flex-direction: column;
  row-gap: 10px;
}

.question-icon {
  background-image: url(../../assets/icon/question-48.png);
  width: 40px;
  height: 40px;
  background-size: contain;
}

.question-title {
  color: var(--color-primary);
}

.comment-icon {
  background-image: url(../../assets/icon/discuss-32.png);
  width: 40px;
  height: 40px;
  background-size: contain;
}

.share-icon {
  background-image: url(../../assets/icon/share-64.png);
  width: 40px;
  height: 40px;
  background-size: contain;
}

.question-replier {
  display: flex;
  column-gap: 16px;
}
</style>
