<template>
    <div>

        <MTToolbar float="right" :actions="countChecked > 0">
          <template v-slot:left>
            <MTextField
              placeholder=""
              right-icon="m-icon search"
            />
          </template>
          <template v-slot:right>
            <MButton
              left-icon="m-icon  reload--icon"
              color="primary"
              variant="secondary"
              @click="formOpen = true"
            ></MButton>
          </template>
          <template v-slot:actions>
            
          </template>
        </MTToolbar>
       <PageBody></PageBody>
    </div>
</template>

<script>
import PageBody from './PageBody.vue'
export default {
  components: {
    PageBody
  },
};
</script>

<style scoped>
.page-content {
  background-color: #808080;
  width: 100%;
}
.m-button 
{

}
</style>
