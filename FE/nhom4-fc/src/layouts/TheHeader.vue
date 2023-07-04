<template>
  <header class="header">
    <div class="header__left">
      <div class="header__menu"></div>
      <div class="header__logo">
        <a class="logo__nav" href="#"> </a>
        <a class="logo__title" href="#">MISA CeGov</a>
      </div>
    </div>
    <div class="header__right">
      <div class="header__action">
        <span class="m-icon notify"></span>
      </div>
      <div class="header__action">
        <span class="m-icon help"></span>
      </div>
      <div class="header__action">
        <span class="m-icon document"></span>
      </div>
      <div class="header__action">
        <span class="m-icon setting"></span>
      </div>
      <div class="header__avatar">
        <img src="../assets/img/getavatar.png" alt="avatar" />
      </div>
    </div>
  </header>
</template>

<script>
export default {
  name: 'TheHeader'
}
</script>