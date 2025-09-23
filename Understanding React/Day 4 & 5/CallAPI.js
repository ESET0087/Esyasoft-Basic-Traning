import React, { useEffect, useState } from 'react'

const useFetch = (url) => {
    const [data, setData] = useState([]);
    const [error, setError] = useState(null);
    const [loading, setLoading] = useState(false);

    const getData = () => {
        setLoading(true);
        fetch(url)
        .then(data => data.json()) 
        .then(jsonData => setData(jsonData))
        .catch((error) => setError(error))
        .finally(() => setLoading(false))
    }

    useEffect(getData, [url]);

    return { data, error, loading, refetch: getData };
}

const CallAPI = () => {
    const {loading, data, error} = useFetch("https://jsonplaceholder.typicode.com/posts")

  return (
    <div>
        {/* <button onClick={getData()}> Load Data </button> */}
        {
            error!=null && <>{error.message}</>
        }
        {
            loading && <>loading....</>
        }
        {
            data.map((e, index) => <div key={index}> {e.id}. {e.title} </div>)
        }
    </div>
  )
}

export default CallAPI