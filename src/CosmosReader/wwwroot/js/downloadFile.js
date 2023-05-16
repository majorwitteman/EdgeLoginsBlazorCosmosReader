window.downloadFile = (fileName, contentType, fileData) => {
    const blob = new Blob([fileData], { type: contentType });
    const url = URL.createObjectURL(blob);

    const anchorElement = document.createElement('a');
    anchorElement.href = url;
    anchorElement.download = fileName;
    document.body.appendChild(anchorElement);
    anchorElement.click();
    document.body.removeChild(anchorElement);

    URL.revokeObjectURL(url);
};
