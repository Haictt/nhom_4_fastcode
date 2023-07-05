<template>
    <div>
        <MisaToolbar></MisaToolbar>
        <PageContent></PageContent>
    </div>
</template>

<script>
import MisaToolbar from './MisaToolbar.vue';
import PageContent from './PageContent.vue'
export default {
    components: {
        MisaToolbar, PageContent
    }
}
</script>