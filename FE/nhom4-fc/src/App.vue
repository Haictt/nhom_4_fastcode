<template>
  <TheHeader></TheHeader>
  <div class="flex--row">
    <TheSideBar></TheSideBar>
    <TheMain></TheMain>
  </div>
</template>


<script>
import TheHeader from './layouts/TheHeader.vue'
import TheSideBar from './layouts/TheSideBar.vue'
import TheMain from './layouts/TheMain.vue'
export default {
  name: 'App',
  components: { TheHeader, TheSideBar, TheMain }
}
</script>