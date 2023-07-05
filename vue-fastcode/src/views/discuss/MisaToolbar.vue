<template>
  <MTToolbar float="right">
    <template v-slot:left>
      <h1>Thảo luận/ Hỏi đáp</h1>
    </template>
    <template v-slot:right>
      <MButton left-icon="m-icon add-white" text="Thêm thảo luận/ Câu hỏi" color="primary" @click="formOpen = true">
      </MButton>
      <TopicCreateForm :open="formOpen" @close="formOpen = false"></TopicCreateForm>
    </template>
    <template v-slot:actions>
    </template>
  </MTToolbar>
</template>

<script>
import TopicCreateForm from './TopicCreateForm.vue';
export default {
  name: 'MisaToolbar',
  components: { TopicCreateForm },
  data() {
    return {
      formOpen: false,
    };
  },
};
</script>
