<template>
    <div class="search" >
        <input type="text" id="search" name="search" v-on:keyup="filterList" placeholder="Search Shopping List..."/>
    </div>
</template>

<script>
export default {
    methods: {
        filterList(){
            const query = document.getElementById('search').value;
            this.$emit('filter-list', query);
        }
    }
}
</script>

<style>
#search {
    width:100%;
    font-size:24px;
    font-family: 'Roboto Condensed', sans-serif;
    padding:10px;
}
</style>
