const AjaxURLCreator = (apiURL, objectData, handlerName = "") => {
  const lastURLCharacter = apiURL.charAt(apiURL.length - 1);
  if (lastURLCharacter === "?" && handlerName !== "") {
    apiURL += `handler=${handlerName}&`;
  }
  else if (lastURLCharacter !== "?" && handlerName !== "") {
    apiURL += `?handler=${handlerName}&`;
  }
  else if (lastURLCharacter !== "?" && handlerName === "") {
    apiURL += '?';
  }
  apiURL += new URLSearchParams(objectData);
  return apiURL;
};

/**
 * Fetch Ajax - Get Content from API.
 * @param {function} AjaxFetchData
 */

const AjaxFetchData = (apiURL) => {
  return new Promise((resolve, reject) => (
    fetch(apiURL)
      .then(response => response.json())
      .then(result => resolve(result))
      .catch(error => reject(error))
  ));
};

/**
 * Fetch Ajax - Post Content to the API.
 * @param {function} AjaxFetchData
 */

const AjaxPostData = (apiURL, objectData) => {
  return new Promise((resolve, reject) => (
    fetch(apiURL, {
      method: 'POST',
      headers: {
        RequestVerificationToken: document.getElementsByName("__RequestVerificationToken")[0].value,
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(objectData)
    })
      .then(response => response.json())
      .then(result => resolve(result))
      .catch(error => reject(error))
  ));
};



