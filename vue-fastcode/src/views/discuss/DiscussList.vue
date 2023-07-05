<template>
  <div>
    <MisaToolbar></MisaToolbar>

    <div>
      <MTToolbar float="right" :actions="countChecked > 0">
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

      <div>
        <div class="question-item">
          <div class="question-icon"></div>
          <div class="question-detail-container">
            <div class="question-title">
              Cần giúp đỡ về việc sử dụng thuộc tính flex
            </div>
            <div class="question-replier">
              <div class="replier">Nguyễn Văn Mạnh</div>
              <div class="number-of-question">Đã trả lời: 100</div>
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
  methods: {
    loadData(){
        fetch("https://cukcuk.manhnv.net/api/v1/Customers")
        .then((res) => res.json())
        .then((data) => {
          this.assets = data;
          this.isLoading = false;
        });
    }
  }
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

.question-replier {
  display: flex;
  column-gap: 16px;
}
</style>
