<template>
  <div id="app">
    <div id="nav">
      <header>
        <ul class="nav">
          <router-link :to="{name: 'home'}" tag="li">Home</router-link> 
          <router-link :to="{name: 'about'}" tag="li">About the Author</router-link> 
          <router-link :to="{name: 'books'}" tag="li">Related Books</router-link>
          <router-link :to="{name: 'empty'}" tag="li">Empty Page</router-link>
        </ul>
      </header>
    </div>
    <router-view class="content"/>
  </div>
</template>

<style>
body {
  margin: 0;
  padding: 0;
}
.content {
  width:800px;
  margin: 20px auto !important;
}
header {
  background-color: #E34232;
}
.nav {
  margin:0;
  padding:0;
  list-style-type: none;
  display: flex;
  justify-content: center;
}
.nav li {
  display: inline-block;
  padding:20px;
  color: #fff;
  background-color: #E34232;
}
.nav li a {
  color: #fff;
  text-transform: uppercase;
  font-size: 14px;
  text-decoration: none;
}
.nav li:hover {
  background-color: rgb(216, 216, 216);
  cursor: pointer;
  color:rgb(44, 44, 44);
}
.nav li a:hover {
  color:rgb(44, 44, 44);
}
.router-link-active {
  background-color: rgb(44, 44, 44);
}
</style>
