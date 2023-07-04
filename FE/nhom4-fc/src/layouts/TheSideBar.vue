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
      <a class="sidebar__item" href="#4">
        <div class="item__icon">
          <span class="m-icon decision--default default"></span>
          <span class="m-icon decision color"></span>
        </div>
        <div class="item__text">
          <span>Quyết định</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Quyết định</div>
      </a>
      <a class="sidebar__item" href="#4">
        <div class="item__icon">
          <span class="m-icon profile--default default"></span>
          <span class="m-icon profile color"></span>
        </div>
        <div class="item__text">
          <span>Hồ sơ</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Hồ sơ</div>
      </a>
      <a class="sidebar__item" href="#4">
        <div class="item__icon">
          <span class="m-icon search--black default"></span>
          <span class="m-icon search--active color"></span>
        </div>
        <div class="item__text">
          <span>Tra cứu</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Tra cứu</div>
      </a>
      <a class="sidebar__item" href="#4">
        <div class="item__icon">
          <span class="m-icon report--default default"></span>
          <span class="m-icon report color"></span>
        </div>
        <div class="item__text">
          <span>Báo cáo</span>
        </div>
        <div class="item__tooltip">Báo cáo</div>
      </a>
      <div class="line"></div>
      <a class="sidebar__item" href="#4">
        <div class="item__icon">
          <span class="m-icon category--default default"></span>
          <span class="m-icon category color"></span>
        </div>
        <div class="item__text">
          <span>Danh mục</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Danh mục</div>
      </a>
      <a class="sidebar__item" href="#4">
        <div class="item__icon">
          <span class="m-icon system--default default"></span>
          <span class="m-icon system color"></span>
        </div>
        <div class="item__text">
          <span>Thiết lập</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Thiết lập</div>
      </a>
      <div class="line"></div>
      <a class="sidebar__item" href="#4">
        <div class="item__icon">
          <span class="m-icon guide--default default"></span>
          <span class="m-icon guide color"></span>
        </div>
        <div class="item__text">
          <span>Hướng dẫn</span>
        </div>
        <div class="item__arrow-right">
          <div class="m-icon arrow-right--default default"></div>
          <div class="m-icon arrow-right color"></div>
        </div>
        <div class="item__tooltip">Hướng dẫn</div>
      </a>
    </div>
    <div class="toggle-button" @click="hidden = !hidden">
      <span>Thu gọn</span>
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