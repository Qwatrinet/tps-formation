export default async function getData(key, url) {
    const data = JSON.parse(localStorage.getItem(key)) ?? []
    
    if (data.length === 0) {
        data.push(...(await (await fetch(url)).json()))
        localStorage.setItem(key, JSON.stringify(data))
    }

    return data
}
