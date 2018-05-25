<template>
  <div id="app">
    <div class="container">
      <GraphqlQueryTextBox/>
    </div>    
  </div>
</template>

<script>
import GraphqlQueryTextBox from './components/GraphqlQueryTextBox.vue'

export default {
  name: 'app',
  components: {
    GraphqlQueryTextBox
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
