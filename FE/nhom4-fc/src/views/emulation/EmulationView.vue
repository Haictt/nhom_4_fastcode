<template>
  <section class="emulation">
    <div class="emulation-title">Danh hiệu thi đua</div>
    <div class="emulation-container">
      <EmulationList></EmulationList>
      <MToastContainer></MToastContainer>
    </div>
  </section>
</template>

<script>
import MToastContainer from '@/components/toast/MToastContainer.vue';
import EmulationList from '../../views/emulation/EmulationList.vue'
export default {
  name: 'EmulationView',
  components: { EmulationList, MToastContainer }
}
</script>

<style scoped>
.emulation {
  width: 100%;
  height: 100%;
  max-height: 100%;
}

.emulation-title {
  margin-bottom: 16px;
  font-size: 20px;
  font-weight: 700;
  line-height: 35px;
}

.emulation-container {
  max-height: calc(100% - 35px - 16px);
  height: calc(100% - 35px - 16px);
  display: flex;
  flex-flow: column nowrap;
}
</style>
