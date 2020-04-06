<template>
  <div class="products">
    <h1>Shop By Department</h1>
    <p>Below is a list of our departments. Please click on a department to view available products by department.</p>
    <div class="departments" v-for="department in departments" :key="department.class">
      <router-link :to="{ name: 'products-list', params: { department: department.class}}" v-bind:class="department.class">
        <img v-bind:src="require('../assets/images/' + department.banner)">
      </router-link>
    </div>
    </div>
</template>

<script>
export default {
  name: "products",
  data() {
    return {
      departments: [
        { path: '/produce', banner: 'produce_banner.png', class: 'produce' },
        { path: '/dairy', banner: 'dairy_banner.png', class: 'dairy' },
        { path: '/meat', banner: 'meat_banner.png', class: 'meat' },
        { path: '/bakery', banner: 'bakery_banner.png', class: 'bakery' }
      ]
    }
  }
}
</script>

<style>
.departments {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
}
</style>
