<template>
  <main class="main">
    <EmulationView></EmulationView>
  </main>
</template>

<script>
import EmulationView from '../views/emulation/EmulationView.vue'
export default {
  name: 'TheMain',
  components: { EmulationView }
}
</script>