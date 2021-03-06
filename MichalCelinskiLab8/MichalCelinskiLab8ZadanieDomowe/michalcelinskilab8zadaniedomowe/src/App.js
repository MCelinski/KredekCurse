import React, { Component } from "react";
import Axios from "axios";
import "./App.css";

// deklaracja endpointu jsonholdera
const EndPoint = 'https://jsonplaceholder.typicode.com/posts'

class App extends Component {
  state = {
    posts: []
  };
  //metoda inicjalizacji zdalnego zasobu
async componentDidMount(){
    const { data: posts } = await Axios.get(EndPoint)
    this.setState({posts})
  }
  //dodawanie 
  handleAdd = async () => {
    const obj = { title: "Kredek", body: "zadanie 8"}
    const { data: post } = await  Axios.post(EndPoint,obj)
    const posts = [post, ...this.state.posts]
    this.setState({posts})
  };

  handleUpdate = async post => {
  post.title="Update"
  await Axios.put(`${EndPoint}/${post.id}`,post)
  const posts = [...this.state.posts]
  const index = posts.indexOf(post)
  posts[index] = {...post}
  this.setState({posts})
  };

  handleDelete = async post => {
  const orginalPosts = this.state.posts
  const posts = this.state.posts.filter(p =>p.id !==post.id)
  this.setState({posts})

  try{
  await Axios.delete(`${EndPoint}/${post.id}`,post)
  } catch(ex){
    if(ex.response && ex.response.status ===404)
    alert(ex)
    this.setState({posts:orginalPosts})
  }
  
  
  };

  render() {
    return (
      <React.Fragment>
        <button className="btn btn-primary" onClick={this.handleAdd}>
          Add
        </button>
        <table className="table">
          <thead>
            <tr>
              <th>Title</th>
              <th>Update</th>
              <th>Delete</th>
            </tr>
          </thead>
          <tbody>
            {this.state.posts.map(post => (
              <tr key={post.id}>
                <td>{post.title}</td>
                <td>
                  <button
                    className="btn btn-info btn-sm"
                    onClick={() => this.handleUpdate(post)}
                  >
                    Update
                  </button>
                </td>
                <td>
                  <button
                    className="btn btn-danger btn-sm"
                    onClick={() => this.handleDelete(post)}
                  >
                    Delete
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </React.Fragment>
    );
  }
}

export default App;
