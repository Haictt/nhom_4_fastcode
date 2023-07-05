<template>
    <div class="question-item">
        <div class="question-icon">

        </div>
        <div class="question-detail-container">
            <div class="question-title">{{ questionTitle }}</div>
            <div class="question-replier">
                <div class="replier">{{ replier }}</div>
                <div class="number-of-question">{{ numberOfQuestion }}</div>
            </div>
        </div>
    </div>
</template>

<script>

export default {
    props: [
        'questionTitle',
        'replier',
        'numberOfQuestion'
    ]
}
</script>

<style scoped>
.question-item{
    display: flex;
    align-items: center;
    column-gap: 16px;
    height: 40px;
    width: 160px;
    padding: 20px;
}

.question-icon{
    background-image: url(../../assets/icon/question-48.png);
    width: 40px;
    height: 40px;
    background-size: contain;
}

.question-replier{
    display: flex;
    column-gap: 16px;
}
</style>