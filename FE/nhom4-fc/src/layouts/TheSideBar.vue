<template>
  <div :class="['sidebar', hidden && 'hidden']">
    <div class="sidebar__content">
      <a class="sidebar__item active" href="#1">
        <div class="item__icon">
          <span class="m-icon dashboard--default default"></span>
          <span class="m-icon dashboard color"></span>
        </div>
        <div class="item__text">
          <span>Tổng quan</span>
        </div>
        <div class="item__tooltip">Tổng quan</div>
      </a>
      <a class="sidebar__item" href="#2">
        <div class="item__icon">
          <span class="m-icon movement--default default"></span>
          <span class="m-icon movement color"></span>
        </div>
        <div class="item__text">
          <span>Thi đua</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Thi đua</div>
      </a>
      <a class="sidebar__item" href="#3">
        <div class="item__icon">
          <span class="m-icon reward--default default"></span>
          <span class="m-icon reward color"></span>
        </div>
        <div class="item__text">
          <span>Khen thưởng</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Khen thưởng</div>
      </a>
    </div>
  </div>
</template>

<script>
export default {
  name: 'TheSideBar',
  data() {
    return {
      hidden: false
    }
  }
}
</script>